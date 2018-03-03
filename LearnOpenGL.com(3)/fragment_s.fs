#version 330 core
out vec4 FragColor;
//"in vec4  vertexColor;"

in vec2 TexCoord;
 //GLSL has a built-in data-type for texture objects called a sampler that takes as a postfix 
                             //the texture type we want e.g. sampler1D, sampler3D or in our case sampler2D.
                            //We can then add a texture to the fragment shader by simply declaring a uniform
							//sampler2D that we later assign our texture 
uniform sampler2D texture1;
uniform sampler2D texture2;
void main()
{

  FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
  //GLSL's built-in mix function takes two values as input and linearly interpolates between them based on its third argument. If the third value is 0.0

  /*
  //To sample the color of a texture we use GLSL's built-in texture 
 // function that takes as its first argument a texture sampler and as
 // its second argument the corresponding texture coordinate. 
 // The texture function then samples the corresponding color value using the texture parameters we set earlier. 
  //The output of this fragment shader is then the (filtered) color of the texture at the (interpolated) texture coordinate. 
  */
};
