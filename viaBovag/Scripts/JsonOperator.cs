using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

using System.Text.Json;
using System.Text.Json.Serialization;

namespace viaBovag
{
    /// <summary>
    /// Class that handles all JSON interactions.
    /// </summary>
    class JsonOperator
    {
        public string jsonString;

        /// <summary>
        /// Read a file and convert file to advertisement object
        /// </summary>
        /// <param name="path">Filepath.</param>
        /// <returns>Converted advertisement object.</returns>
        public Advertisement deserializeJson(string path)
        {
            Advertisement advertisement = new Advertisement();

            jsonString = File.ReadAllText(path);

            advertisement = JsonConvert.DeserializeObject<Advertisement>(jsonString);

            return advertisement;
        }

        /// <summary>
        /// Convert teaser object to JSON
        /// </summary>
        /// <param name="teaser">Teaser to be converted.</param>
        /// <returns>Converted json teaser string.</returns>
        public string serializeJson(Teaser teaser)
        {
            return JsonConvert.SerializeObject(teaser);
        }

        /// <summary>
        /// Writes json teaser string to teasers file.
        /// </summary>
        /// <param name="path">Path of teasers file.</param>
        /// <param name="text">JSON teaser string.</param>
        public void teaserFile(string path, string text)
        {
            File.AppendAllText(path, text);
        }
    }
}
