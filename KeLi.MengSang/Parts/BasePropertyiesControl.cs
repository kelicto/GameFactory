﻿using System.ComponentModel;

using KeLi.GameFactory.UI;

namespace KeLi.MengSang.Parts
{
    public partial class BasePropertyiesControl : ShadowControl
    {
        public BasePropertyiesControl()
        {
            InitializeComponent();
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string FirstProperty
        {
            get => lblFirstProperty.Text;
            set => lblFirstProperty.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string SecondProperty
        {
            get => lblSecondProperty.Text;
            set => lblSecondProperty.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string ThirdProperty
        {
            get => lblThirdProperty.Text;
            set => lblThirdProperty.Text = value;
        }

        [Category("Appearance")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        public string FourthProperty
        {
            get => lblFourthProperty.Text;
            set => lblFourthProperty.Text = value;
        }
    }
}