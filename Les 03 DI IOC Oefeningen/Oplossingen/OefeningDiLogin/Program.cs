using Interfaces;
using LoginAdapters;
using Ninject;
using OefeningDiLogin;

var kernel = new StandardKernel();
kernel.Bind<ILogin>().To<HardCodedLoginAdapter>();

Console.WriteLine(kernel.ToString());

var verySecretApplication = kernel.Get<VerySecretApplication>();
verySecretApplication.Start();
Console.ReadLine();