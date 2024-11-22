namespace Weather_Rider
{
    partial class ReadOnlyRichTextBox
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(100, 96);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox;
    }
}
