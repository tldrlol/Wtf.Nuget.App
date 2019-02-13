namespace Wtf.Nuget.App {

  using System.Windows;
  using Dep;

  public partial class App : Application {
    protected override void OnStartup(StartupEventArgs e) {
      var c1 = new Class1();
    }
  }

}