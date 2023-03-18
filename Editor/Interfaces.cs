// NOTE: "abstract static" definition in interface requires C# 11.0 or later.
//       following code is just for reference for future enhancement.
#if UNITY_2025_1_OR_NEWER

using System.Text;

namespace SatorImaging.UnitySourceGenerator
{
    public interface IUnitySourceGenerator
    {
        ///<summary>Return true if write StringBuilder content to file.</summary>
        abstract static bool Emit(in USGContext context, in StringBuilder sb);

        ///<summary>Return just only filename with extension. SourceGenerator will automatically arrange output path.</summary>
        abstract static string OutputFileName();

    }
}

#endif
