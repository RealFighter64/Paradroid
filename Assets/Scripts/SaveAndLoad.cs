using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

class SaveAndLoad
{
    public static BinaryFormatter binaryFormatter;

    public static string Serialize (object obj) {
        MemoryStream memoryStream = new MemoryStream ();
        binaryFormatter.Serialize (memoryStream, obj);
        string serialized = System.Convert.ToBase64String (memoryStream.ToArray ());
        return serialized;
    }

    public static object Deserialize (string serialized) {
        if (serialized == string.Empty) {
            return null;
        }
        MemoryStream memoryStream = new MemoryStream (System.Convert.FromBase64String (serialized));
        object obj = binaryFormatter.Deserialize (memoryStream);
        return obj;
    }

    public static void Save (object obj, string saveTag) {
        string serialized = Serialize (obj);
        PlayerPrefs.SetString (saveTag, serialized);
    }

    public static object Load (string saveTag) {
        string serialized = PlayerPrefs.GetString (saveTag);
        object obj = Deserialize (serialized);
        return obj;
    }

    public static void SaveAll () {
        Save (GameInformationHolder.gameInformation, "GAMEINFORMATION");
    }

    public static void LoadAll () {
        object obj = Load ("GAMEINFORMATION");
        GameInformationHolder.gameInformation = (GameInformation) obj;
    }
}