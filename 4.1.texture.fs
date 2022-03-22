#version 330 core
out vec4 FragColor;

in vec3 ourColor;
in vec2 TexCoord;

// Текстурный сэмплер
uniform sampler2D texture;
uniform sampler2D texture2;

void main()
{
	FragColor = mix(texture(texture, TexCoord), texture(texture2, TexCoord), 0.5);
}