namespace MIFARE_APP.Config
{
    public class RuntimeParams
    {
        public static readonly string AssetsDirKey = "-AssetsDir:";
        public static readonly string PinelineKey = "-Pipeline:";

        public string AssetsDirectory { get; private set; }
        public bool InPipeline{ get; private set; } = false;

        public void ParseArguments(string[] arguments)
        {
            foreach (string arg in arguments)
            {
                if (arg.StartsWith(AssetsDirKey))
                {
                    AssetsDirectory = arg.Substring(AssetsDirKey.Length);
                    continue;
                }

                if (arg.StartsWith(PinelineKey))
                {
                    InPipeline = arg.EndsWith(":true");
                    continue;
                }
            }
        }

        public override string ToString()
        {
            return $"AssetsDirectory='{AssetsDirectory}', InPipeline='{InPipeline}'";
        }
    }
}
