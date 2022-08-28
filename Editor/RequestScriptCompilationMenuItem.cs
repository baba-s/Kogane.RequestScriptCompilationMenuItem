using UnityEditor;
using UnityEditor.Compilation;

namespace Kogane.Internal
{
    internal static class RequestScriptCompilationMenuItem
    {
        [MenuItem( "Kogane/コンパイル開始" )]
        private static void RequestScriptCompilation()
        {
            CompilationPipeline.RequestScriptCompilation();
        }
    }
}