using Slender.Scanner;
using Slender.Scanner.Sample;

var _AssemblyScan = AssemblyScan.FromAssembly(typeof(Program).Assembly);
var _Visitor = new LoggingVisitor();

_Visitor.VisitAssemblyScan(_AssemblyScan);
