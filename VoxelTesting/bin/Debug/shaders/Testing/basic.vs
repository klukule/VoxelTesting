uniform mat4 projection_matrix;
uniform mat4 model_matrix;
uniform mat4 view_matrix;

attribute vec3 in_position;
attribute vec3 in_normal;

varying vec3 vertex_light_position;
varying vec3 vertex_normal;
varying vec3 vertex_position;

void main(void)
{
  vertex_normal = in_normal;
  vertex_light_position = normalize(vec3(0.1, 0.5, 0.1));
  vertex_position = in_position;
  gl_Position = projection_matrix * view_matrix * model_matrix * vec4(in_position, 1);
}
