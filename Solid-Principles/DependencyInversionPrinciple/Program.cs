// See https://aka.ms/new-console-template for more information

using DependencyInversionPrinciple.AfterRefactoring;
using DependencyInversionPrinciple.BeforeRefactoring;


//The Dependency Inversion Principle promotes the decoupling of high-level modules from low-level modules by introducing abstractions.
//The main idea behind DIP is that higher-level modules should not depend on lower-level modules; instead, they should both depend on abstractions.
//and abstractions should not depend on implemenntation details , implementation details should depend on abstraction


//Before Refactoring
// in this case MaintenanceService class is instanciated in GowraPalladium class ... but in case there are some changes in MaintenenceServices then we will have errors ...
//GowraPalladium is tightly coupled with MaintenanceService class and it is even coupled with Maintenance method of the class...
var gp1 = new DependencyInversionPrinciple.BeforeRefactoring.GowraPalladium();
gp1.maintain();

//After Refactoring
var maintenanceService = new DependencyInversionPrinciple.AfterRefactoring.MaintenanceService();
var gp2 = new DependencyInversionPrinciple.AfterRefactoring.GowraPalladium(maintenanceService);
gp2.maintain();
