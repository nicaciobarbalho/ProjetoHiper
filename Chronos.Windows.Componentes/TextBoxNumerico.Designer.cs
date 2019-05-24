namespace Chronos.Windows.Componentes
{
    partial class TextBoxNumerico
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            decimalSeparator = numberFormatInfo.NumberDecimalSeparator;
            groupSeparator = numberFormatInfo.NumberGroupSeparator;
            negativeSign = numberFormatInfo.NegativeSign;
            positiveSign = numberFormatInfo.PositiveSign;
            _decimalNumber = 15;
            _groupSeparator = groupSeparator[0];
            _maxValue = 0;
            _minValue = 0;
            _maxCheck = false;
            _minCheck = false;
            _oldText = "";
        }

        #endregion
    }
}
