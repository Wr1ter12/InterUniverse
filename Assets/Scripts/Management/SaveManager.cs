using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class SaveManager : MonoBehaviour
{
    public static SaveManager Instance { get; set; }
    public ObjDB ObjDB;
    GameObject go;
    [SerializeField] string world;
    [SerializeField] GravitySystem gravitysys;
    [SerializeField] ButtonDestroy buttondestroy;
    [SerializeField] ButtonTrail buttontrail;
    [SerializeField] GameObject planet;
    [SerializeField] GameObject star;
    [SerializeField] GameObject asteroid;
    [SerializeField] GameObject blackhole;
    [SerializeField] GameObject whitehole;

    void Start()
    {
        Instance = this;
        LoadData();
    }

    public void AddObj(GameObject obje, string prefab)
    {
        Obj obj = new Obj();
        if(prefab == "NaN")
        {   
            string mat = obje.GetComponent<Renderer>().material.name.Replace(" (Instance)","");
            switch(mat)
            {
                case "Mercury":
                    prefab = "planet";
                    break;
                case "Sun":
                    prefab = "star";
                    break;
                case "Asteroids":
                    prefab = "asteroid";
                    break;
                case "BlackHolecenter":
                    prefab = "blackhole";
                    break;
                case "WhiteHolecenter":
                    prefab = "whitehole";
                    break;
                default:
                    break;
            }
        }
        obj.PrefabID = prefab;
        obj.ObjID = obje.name;
        obj.Position = obje.transform.position;
        obj.mass = obje.GetComponent<Rigidbody>().mass;
        obj.ax = obje.GetComponent<SpeedController>().speed;
        obj.scale = obje.transform.localScale;
        ObjDB.objects.Add(obj);
    }

    public void RemoveObj(string objID)
    {
        Obj obj = ObjDB.objects.Where(p => p.ObjID == objID).First();
        ObjDB.objects.Remove(obj);
    }

    public void SaveData()
    {
        foreach(GameObject a in gravitysys.celestials)
        {
            if(a != null)
            {
                try
                {
                    RemoveObj(a.name);
                }
                catch{}
            }
        }
        foreach(GameObject a in gravitysys.celestials)
        {
            if(a != null)
            {
                string mat = a.GetComponent<Renderer>().material.name.Replace(" (Instance)","");
                switch(mat)
                {
                    case "Mercury":
                        AddObj(a, "planet");
                        break;
                    case "Sun":
                        AddObj(a, "star");
                        break;
                    case "Asteroids":
                        AddObj(a, "asteroid");
                        break;
                    case "BlackHolecenter":
                        AddObj(a, "blackhole");
                        break;
                    case "WhiteHolecenter":
                        AddObj(a, "whitehole");
                        break;
                    default:
                        break;
                }
            }
        }
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObjDB));
        try
        {
            if (!Directory.Exists(Application.dataPath + "/Saves"))
            {
                Directory.CreateDirectory(Application.dataPath + "/Saves");
            }
        
        }
        catch {}
        FileStream stream = new FileStream(Application.dataPath + "/Saves/World" + world + ".xml", FileMode.Create);
        xmlSerializer.Serialize(stream, ObjDB);
        stream.Close();
    }

    void LoadData()
    {
        if(!File.Exists(Application.dataPath + "/Saves/World" + world + ".xml")) return;
        XmlSerializer xmlSerializer = new XmlSerializer(typeof(ObjDB));
        FileStream stream = new FileStream(Application.dataPath + "/Saves/World" + world + ".xml", FileMode.Open);
        ObjDB = xmlSerializer.Deserialize(stream) as ObjDB;
        stream.Close();

        foreach(Obj obj in ObjDB.objects)
        {
            switch(obj.PrefabID)
            {
                case "planet":
                    go = Instantiate(planet, obj.Position, Quaternion.identity);
                    break;
                case "star":
                    go = Instantiate(star, obj.Position, Quaternion.identity);
                    break;
                case "asteroid":
                    go = Instantiate(asteroid, obj.Position, Quaternion.identity);
                    break;
                case "blackhole":
                    go = Instantiate(blackhole, obj.Position, Quaternion.identity);
                    break;
                case "whitehole":
                    go = Instantiate(whitehole, obj.Position, Quaternion.identity);
                    break;
                default:
                    break;
            }
            go.name = obj.ObjID;
            go.GetComponent<Rigidbody>().mass = obj.mass;
            go.GetComponent<SpeedController>().speed = obj.ax;
            go.gameObject.transform.localScale = obj.scale;
        }
        if(ObjDB.objects.Count.Equals(0))
        {
            gravitysys.Celestials();
            buttontrail.Celestials();
            buttondestroy.Celestials();
        }
    }
}

[System.Serializable]
public class ObjDB
{
    public List<Obj> objects = new List<Obj>();
}

[System.Serializable]
public class Obj
{
    public string ObjID;
    public string PrefabID;
    public Vector3 Position;
    public float mass;
    public float ax;
    public Vector3 scale;
}
