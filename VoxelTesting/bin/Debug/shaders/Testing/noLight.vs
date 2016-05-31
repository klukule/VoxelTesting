uniform mat4 projection_matrix;
uniform mat4 model_matrix;
uniform mat4 view_matrix;

attribute vec3 in_position;
attribute vec3 in_normal;

void main(void)
{
  gl_Position = projection_matrix * view_matrix * model_matrix * vec4(in_position, 1);
}
