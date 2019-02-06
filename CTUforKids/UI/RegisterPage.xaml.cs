﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using CTUforKids.ViewModels;
using CTUforKids.Common;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace CTUforKids.UI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class RegisterPage : Page
    {
        private RegisterVM VM;
        public RegisterPage()
        {
            this.InitializeComponent();
            VM = new RegisterVM(new NavigationService());
            this.DataContext = VM;
        }
    }
}
