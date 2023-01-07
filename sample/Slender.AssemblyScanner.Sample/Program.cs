using Slender.AssemblyScanner;
using Slender.AssemblyScanner.Sample;

var _AssemblyScan = AssemblyScan.FromAssembly(typeof(Program).Assembly);
var _Visitor = new LoggingVisitor();

_Visitor.VisitAssemblyScan(_AssemblyScan);
