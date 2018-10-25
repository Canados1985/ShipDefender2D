using UnityEngine;
using System.Collections;

public struct TextureData
{
	public string name;
	public float x;
	public float y;
	public float width;
	public float height;	
}

public class Sprite : MonoBehaviour 
{
	public string imageName;
	private TextureData data;

    

    // Use this for initialization
    void Start () 
	{
		//get the data for this texture from the atlas.
		data = TextureManager.Instance.GetTexture(imageName);
		
		//create our new uv coordinates from the texture atlas data
		Vector2[] uvs = new Vector2[4];
        
		uvs[0].x = data.x;
		uvs[0].y = 1 - (data.y + data.height);
		uvs[1].x = (data.x + data.width);
		uvs[1].y = 1 - data.y;
		uvs[2].x = (data.x + data.width);
		uvs[2].y = 1 - (data.y + data.height);
		uvs[3].x = data.x;
		uvs[3].y = 1 - data.y;


        //get the mesh and change it's uv coordinates.
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.uv = uvs;

    }


}
