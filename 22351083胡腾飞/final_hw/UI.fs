#version 330 core
out vec4 FragColor;

in vec2 TexCoords;

uniform sampler2D texture1;
uniform float opacity;

void main()
{
    FragColor = texture(texture1, TexCoords) * vec4(1.0, 1.0, 1.0, 0.4);
}