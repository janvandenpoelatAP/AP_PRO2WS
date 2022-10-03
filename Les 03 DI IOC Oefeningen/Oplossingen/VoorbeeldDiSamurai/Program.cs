using Ninject;
using OplossingDiOefeningSamurai;

var kernel = new StandardKernel();
kernel.Bind<IWeapon>().To<Gun>();
kernel.Bind<ITrigger>().To<AutomaticTrigger>();

var warrior = kernel.Get<Samurai>();
warrior.Attack("the evildoers");