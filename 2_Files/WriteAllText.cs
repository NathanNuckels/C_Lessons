using System.IO;
using System.Threading.Tasks;
namespace _2_Files{
    class WriteAllText
    {
    public static async Task write(string fileName,string text)
    {
        await File.WriteAllTextAsync(fileName, text);
    }
}
}
