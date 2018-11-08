using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Phoneword
{
    public partial class InstructionPracticePage : ContentPage
    {
        public static string[] BuyList { get; set; }
        public InstructionPracticePage()
        {
            BuyList = new string[] {
                "Buy pears", "Buy oranges", "Buy mangos", "Buy apples", "Buy bananas"
            };
            InitializeComponent();
        }
    }
}
