// Copyright (c) 2010 Alfxp
// License: Code Project Open License
// http://www.codeproject.com/info/cpol10.aspx

using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Data;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Diagnostics;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Tyranny.GoogleTranslator
{

    public partial class TyrannyGoogleTranslatorFrm : Form
    {
        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="TyrannyGoogleTranslatorFrm"/> class.
        /// </summary>
        public TyrannyGoogleTranslatorFrm()
        {
            InitializeComponent();
        }

        #endregion

        #region Form event handlers

        /// <summary>
        /// Handles the Load event of the GoogleTranslatorFrm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GoogleTranslatorFrm_Load
            (object sender,
             EventArgs e)
        {
            this._comboFrom.Items.AddRange(Translator.Languages.ToArray());
            this._comboTo.Items.AddRange(Translator.Languages.ToArray());
            this._comboFrom.SelectedItem = "English";
            this._comboTo.SelectedItem = "Portuguese";
        }

        #endregion

        #region Button handlers

        /// <summary>
        /// Handles the LinkClicked event of the _lnkSourceEnglish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkSourceEnglish_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {
            this._comboFrom.SelectedItem = "English";
        }

        /// <summary>
        /// Handles the LinkClicked event of the _lnkTargetEnglish control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkTargetEnglish_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {
            this._comboTo.SelectedItem = "Portuguese";
        }

        /// <summary>
        /// Handles the Click event of the _btnTranslate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void _btnTranslate_Click
            (object sender,
             EventArgs e)
        {

            Stopwatch sw = Stopwatch.StartNew();

            // Initialize the translator
            Translator t = new Translator();

            this._editTarget.Text = string.Empty;
            this._editTarget.Update();
            this._translationSpeakUrl = null;

            // Translate the text
            try
            {
                this.Cursor = Cursors.WaitCursor;
                this._lblStatus.Text = "Traduzindo...";
                this._lblStatus.Update();
                this._editTarget.Text = t.Translate(this._editSourceText.Text.Trim(), (string)this._comboFrom.SelectedItem, (string)this._comboTo.SelectedItem);

                var LanguageFrom = (string)this._comboFrom.SelectedItem;
                var LanguageTo = (string)this._comboTo.SelectedItem;

                //Lendo os arquivos xmls do Tirany.
                var folderPath = @"E:\Games\Tyranny\_Data\";
                string[] allfiles = Directory.GetFiles(folderPath, "*.stringtable", SearchOption.AllDirectories);
                foreach (var file in allfiles)
                {
                    try
                    {

                        var info = new FileInfo(file);                        

                        var ds = new DataSet();

                        //Read File
                        ds.ReadXml(info.FullName);


                        List<int> PositionsInitial;
                        List<int> PositionsFinal;
                        List<string> phraseReserveWord = new List<string> { };

                        foreach (DataRow dr in ds.Tables[2].Rows)
                        {
                            var phrase = (string)@dr["DefaultText"];

                            //Teste
                            //phrase=@"A Havoc. Raetommon whispers the word in the throes of renewed ecstasy, a maniacal glint shining in his eyes that grows and ebbs in intensity as the light undulates over his face. Let [url=glossary:kyros]Kyros[/url] send his forces. They won't win. I will raze [url=glossary:lethian's crossing]Lethian's Crossing[/url] before I let him have it. Before I let you stop me. He looks at you, dangerously manic light in his eyes. THIS IS MY CITY!";                            
                            var phraseOrinal = phrase;

                            //Palavras revervadas. sistema de Link do game.
                            const string searh = "[url";
                            const string searh2 = "url]";
                            var SubStringLink = "";

                            phraseReserveWord.Clear();
                            PositionsInitial = GetPositions(phrase, searh);
                            PositionsFinal = GetPositions(phrase, searh2);
                            var w5 = "";

                            for (int i = 0; i < PositionsInitial.Count; i++)
                            {
                                SubStringLink = phrase.Substring(PositionsInitial[i], (PositionsFinal[i] - PositionsInitial[i] + 4));
                                var IsNumeric = Regex.IsMatch(SubStringLink, @"^\d+$");

                                if (!phraseReserveWord.Any(x => x.Contains(SubStringLink)) && !IsNumeric)
                                {
                                    phrase = phrase.Replace(SubStringLink, w5.PadLeft(SubStringLink.Length, (char)(phraseReserveWord.Count() + 49)));
                                    phraseReserveWord.Add(SubStringLink);
                                }
                            }

                            //Palavras reservadas link e Game
                            Task ta = Task.Run(() =>
                            {

                                //Existe outras palavras reservadas além do link  '[url'
                                //Não traduzir as outras palavras originais.
                                if (phrase.IndexOf("[") != 0)
                                {
                                    var phraseGoogle = t.Translate(phrase, LanguageFrom, LanguageTo);

                                    for (int i = 0; i < phraseReserveWord.Count(); i++)
                                    {
                                        //O google tem um Bug no seu retorno. ele trunca os valore repetidos como 111111111111111,22222222222222222,333333333333333333333
                                        //isso atrapalha o parse. (estou procurando/analisando outras feramentas de tradução.)
                                        phraseGoogle = phraseGoogle.Replace(w5.PadLeft(phraseReserveWord[i].Length, (char)(i + 49)), phraseReserveWord[i]);
                                    }

                                    dr["DefaultText"] = phraseGoogle;
                                }
                                else
                                {
                                    dr["DefaultText"] = phraseOrinal;
                                }


                            });
                            ta.Wait();
                        }

                        Task tb = Task.Run(() =>
                        {
                            //If a folder does not exist, create it
                            if (!Directory.Exists(Path.GetDirectoryName(info.FullName.Replace("en", "pt"))))
                            {
                                Directory.CreateDirectory(Path.GetDirectoryName(info.FullName.Replace("en", "pt")));
                            }

                            //Gravando o arquivo.
                            ds.WriteXml(info.FullName.Replace("en", "pt"));
                        });
                        tb.Wait();
                    }

                    //Continue caso tenha erro.
                    catch (Exception ex)
                    {
                        var ss = ex;
                        continue;
                    }

                    sw.Stop();
                }
                //Lendo os arquivos xmls do Tirany.

                if (t.Error == null)
                {
                    this._editTarget.Update();
                    this._translationSpeakUrl = t.TranslationSpeechUrl;
                }
                else
                {
                    MessageBox.Show(t.Error.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                this._lblStatus.Text = string.Format("Traduzido em {0} ", sw.Elapsed.TotalMinutes);
                this.Cursor = Cursors.Default;
            }
        }

        public List<int> GetPositions(string source, string searchString)
        {
            List<int> ret = new List<int>();
            int len = searchString.Length;
            int start = -len;
            while (true)
            {
                start = source.IndexOf(searchString, start + len, StringComparison.CurrentCulture);
                if (start == -1)
                {
                    break;
                }
                else
                {
                    ret.Add(start);
                }
            }
            return ret;
        }

        /// <summary>
        /// Handles the Click event of the _btnSpeak control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void _btnSpeak_Click
                (object sender,
                 EventArgs e)
        {
            if (!string.IsNullOrEmpty(this._translationSpeakUrl))
            {
                this._webBrowserCtrl.Navigate(this._translationSpeakUrl);
            }
        }

        /// <summary>
        /// Handles the LinkClicked event of the _lnkReverse control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.LinkLabelLinkClickedEventArgs"/> instance containing the event data.</param>
        private void _lnkReverse_LinkClicked
            (object sender,
             LinkLabelLinkClickedEventArgs e)
        {
            // Swap translation mode
            string from = (string)this._comboFrom.SelectedItem;
            string to = (string)this._comboTo.SelectedItem;
            this._comboFrom.SelectedItem = to;
            this._comboTo.SelectedItem = from;

            // Reset text
            this._editSourceText.Text = this._editTarget.Text;
            this._editTarget.Text = string.Empty;
            this.Update();
            this._translationSpeakUrl = string.Empty;
        }

        #endregion

        #region Fields

        /// <summary>
        /// The URL used to speak the translation.
        /// </summary>
        private string _translationSpeakUrl;

        #endregion

        private void _editSourceText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
