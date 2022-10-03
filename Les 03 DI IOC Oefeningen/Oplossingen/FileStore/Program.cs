using FileStore;
using Ninject;

IKernel kernel = new StandardKernel();
kernel.Bind<IPrinter>().To<FilePrinter>();
var arrayStore = kernel.Get<ArrayStore>();

arrayStore.Store(new string[] { "Een", "Twee", "Drie" });