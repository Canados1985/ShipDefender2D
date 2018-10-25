using UnityEngine;
using System.Collections;
using System.Xml;
using System.IO;

public class TextureManager : MonoBehaviour 
{
	public Texture2D textureFile;
	public TextAsset atlasFile;
	private TextureData[] atlas; 
	
	public static TextureManager Instance { get { return instance; } }
	
	private static TextureManager instance = null;
	
	void Awake()
	{
		if (instance != null && instance != this)
		{
			Destroy(this.gameObject);
			return;        
		} 
		else 
		{
			instance = this;
		}
		DontDestroyOnLoad(this.gameObject);
		
		string textData = atlasFile.text;
		ParseXML( textData );
	}
	
	//load the xml file and parse it.
	private void ParseXML(string xmlData) 
	{
		XmlDocument xmlDoc = new XmlDocument();
		xmlDoc.Load( new StringReader(xmlData) );
		string xmlPathPattern = "//atlas/image";
		XmlNodeList nodeList = xmlDoc.SelectNodes(xmlPathPattern );
		atlas = new TextureData[nodeList.Count];
		int counter = 0;
		foreach(XmlNode node in nodeList)
		{
			atlas[counter] = ParseNode(node);
			counter++;
		}
	}
	
	//get the data from each image node.
	private TextureData ParseNode(XmlNode node)
	{
		//grab the nodes
		XmlNode nameNode = node.FirstChild;
		XmlNode xNode = nameNode.NextSibling;
		XmlNode yNode = xNode.NextSibling;
		XmlNode widthNode = yNode.NextSibling;
		XmlNode heightNode = widthNode.NextSibling;
		
		//create the data struct
		TextureData data;
		data.name = nameNode.InnerXml;
		data.x = int.Parse(xNode.InnerXml);
		data.y = int.Parse(yNode.InnerXml);
		data.width = int.Parse(widthNode.InnerXml);
		data.height = int.Parse(heightNode.InnerXml);
		
		//now scale the struct to uv normals (i.e. a 0 to 1 range)
		data.x /= textureFile.width;
		data.y /= textureFile.height;
		data.width /= textureFile.width;
		data.height /= textureFile.height;
		
		return data;
	}
	
	//find the data they want from our atlas.
	public TextureData GetTexture(string name)
	{
		//Search for the texture data he wants
		foreach(TextureData data in atlas)
		{
			if(data.name == name)
			{
				return data;
			}
		}
		
		//otherwise texture not found, so return an empty one.
		return new TextureData();
	}
}
