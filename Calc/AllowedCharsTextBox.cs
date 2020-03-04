/*
 * Quelle: https://www.mycsharp.de/wbb2/thread.php?threadid=17535
 */

using System;
using System.Text;
using System.Windows.Forms;

namespace Calc
{
    //*************************************************************
    public class AllowedCharsTextBox : TextBox
    {
        //----------------------------------------------------------
        private String _allowedChars = "-.0123456789,";
        // Um von einer bestimmten Kultur unabhängig zu sein, kann man statt "-" und "," besser
        // System.Globalization.NumberFormatInfo.CurrentInfo.NegativeSign und
        // System.Globalization.NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
        // verwenden
        private String _lastValidText = "";
        private int _lastValidSelectionStart = 0;
        private int _lastValidSelectionLength = 0;
        private bool _validating = false;

        //==========================================================
        public String AllowedChars
        {
            get { return _allowedChars; }
            set
            {
                _allowedChars = value;
                Text = Text; //Text von nun ungültigen Zeichen "bereinigen"
            }
        }

        //==========================================================
        public override String Text
        {
            get { return base.Text; }
            set
            {
                StringBuilder onlyValid = new StringBuilder();

                foreach (char ch in value)
                {
                    if (_allowedChars.Contains(ch.ToString()))
                    {
                        onlyValid.Append(ch);
                    }
                }

                base.Text = onlyValid.ToString();
            }
        }

        //==========================================================
        protected override void OnTextChanged(EventArgs e)
        {
            if (_validating)
            {
                return;
            }
            try
            {
                _validating = true;

                foreach (char ch in base.Text)
                {
                    if (!_allowedChars.Contains(ch.ToString()))
                    {
                        base.Text = _lastValidText;
                        SelectionStart = _lastValidSelectionStart;
                        SelectionLength = _lastValidSelectionLength;
                        return;
                    }
                }
                _lastValidText = base.Text;
                _lastValidSelectionStart = SelectionStart;
                _lastValidSelectionLength = SelectionLength;
                base.OnTextChanged(e);
            }
            finally
            {
                _validating = false;
            }
        }

        //==========================================================
        protected override void OnClick(EventArgs e)
        {
            _lastValidSelectionStart = SelectionStart;
            _lastValidSelectionLength = SelectionLength;
            base.OnClick(e);
        }

        //==========================================================
        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (base.Text == _lastValidText)
            {
                _lastValidSelectionStart = SelectionStart;
                _lastValidSelectionLength = SelectionLength;
            }
            base.OnKeyDown(e);
        }

        //==========================================================
        protected override void OnKeyUp(KeyEventArgs e)
        {
            if (base.Text == _lastValidText)
            {
                _lastValidSelectionStart = SelectionStart;
                _lastValidSelectionLength = SelectionLength;
            }
            base.OnKeyUp(e);
        }

    }//end class
}//end namespace
