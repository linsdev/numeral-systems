using System;
using System.CodeDom.Compiler;
using System.Reflection;
using Microsoft.JScript;

public static class Calc // Java Script Functions
{
    private static Type _evaluatorType;
    private static object _evaluatorInstance;
    private static readonly string _jscriptEvalClass =
    @"import System;
class JScriptEvaluator
{
    public static function Eval(expression : String) : String
    { return eval(expression); }
}";

    private static void Initialize()
    {

        CodeDomProvider compiler = new JScriptCodeProvider();

        CompilerParameters parameters = new CompilerParameters();
        parameters.GenerateInMemory = true;
        parameters.ReferencedAssemblies.Add("system.dll");

        CompilerResults results = compiler.CompileAssemblyFromSource(parameters, _jscriptEvalClass);

        Assembly assembly = results.CompiledAssembly;
        _evaluatorType = assembly.GetType("JScriptEvaluator");
        _evaluatorInstance = Activator.CreateInstance(_evaluatorType);
    }

    public static string Eval(string expression)
    {
        if (_evaluatorInstance == null)
            Initialize();
        object result;
        try {
            result = _evaluatorType.InvokeMember(
                "Eval", BindingFlags.InvokeMethod, null,
                _evaluatorInstance, new object[] { expression });
        }
        catch {
            return "";
        }
        return (result == null) ? null : result.ToString();
    }
}