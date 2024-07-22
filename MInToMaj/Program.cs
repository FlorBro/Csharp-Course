
using Model;
using ViewModel;

var textVM = new InputTextVM();
textVM.OriginalTextVm = Console.ReadLine(); 
Console.WriteLine(textVM.Convert());