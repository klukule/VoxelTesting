﻿using System;
using System.Runtime.InteropServices;

namespace klukule.OpenGL
{
    partial class Gl
    {
        internal static partial class Core
        {
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glActiveShaderProgram", ExactSpelling = true)]
            internal extern static void ActiveShaderProgram(UInt32 pipeline, UInt32 program);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glActiveTexture", ExactSpelling = true)]
            internal extern static void ActiveTexture(klukule.OpenGL.TextureUnit texture);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glAttachShader", ExactSpelling = true)]
            internal extern static void AttachShader(UInt32 program, UInt32 shader);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginConditionalRender", ExactSpelling = true)]
            internal extern static void BeginConditionalRender(UInt32 id, klukule.OpenGL.ConditionalRenderType mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndConditionalRender", ExactSpelling = true)]
            internal extern static void EndConditionalRender();
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginQuery", ExactSpelling = true)]
            internal extern static void BeginQuery(klukule.OpenGL.QueryTarget target, UInt32 id);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndQuery", ExactSpelling = true)]
            internal extern static void EndQuery(klukule.OpenGL.QueryTarget target);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginQueryIndexed", ExactSpelling = true)]
            internal extern static void BeginQueryIndexed(UInt32 target, UInt32 index, UInt32 id);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndQueryIndexed", ExactSpelling = true)]
            internal extern static void EndQueryIndexed(klukule.OpenGL.QueryTarget target, UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBeginTransformFeedback", ExactSpelling = true)]
            internal extern static void BeginTransformFeedback(klukule.OpenGL.BeginFeedbackMode primitiveMode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEndTransformFeedback", ExactSpelling = true)]
            internal extern static void EndTransformFeedback();
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindAttribLocation", ExactSpelling = true)]
            internal extern static void BindAttribLocation(UInt32 program, UInt32 index, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBuffer", ExactSpelling = true)]
            internal extern static void BindBuffer(klukule.OpenGL.BufferTarget target, UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBufferBase", ExactSpelling = true)]
            internal extern static void BindBufferBase(klukule.OpenGL.BufferTarget target, UInt32 index, UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBufferRange", ExactSpelling = true)]
            internal extern static void BindBufferRange(BufferTarget target, UInt32 index, UInt32 buffer, IntPtr offset, IntPtr size);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBuffersBase", ExactSpelling = true)]
            internal extern static void BindBuffersBase(klukule.OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindBuffersRange", ExactSpelling = true)]
            internal extern static void BindBuffersRange(klukule.OpenGL.BufferTarget target, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, IntPtr[] sizes);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindFragDataLocation", ExactSpelling = true)]
            internal extern static void BindFragDataLocation(UInt32 program, UInt32 colorNumber, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindFragDataLocationIndexed", ExactSpelling = true)]
            internal extern static void BindFragDataLocationIndexed(UInt32 program, UInt32 colorNumber, UInt32 index, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindFramebuffer", ExactSpelling = true)]
            internal extern static void BindFramebuffer(klukule.OpenGL.FramebufferTarget target, UInt32 framebuffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindImageTexture", ExactSpelling = true)]
            internal extern static void BindImageTexture(UInt32 unit, UInt32 texture, Int32 level, Boolean layered, Int32 layer, klukule.OpenGL.BufferAccess access, klukule.OpenGL.PixelInternalFormat format);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindImageTextures", ExactSpelling = true)]
            internal extern static void BindImageTextures(UInt32 first, Int32 count, UInt32[] textures);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindProgramPipeline", ExactSpelling = true)]
            internal extern static void BindProgramPipeline(UInt32 pipeline);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindRenderbuffer", ExactSpelling = true)]
            internal extern static void BindRenderbuffer(klukule.OpenGL.RenderbufferTarget target, UInt32 renderbuffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindSampler", ExactSpelling = true)]
            internal extern static void BindSampler(UInt32 unit, UInt32 sampler);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindSamplers", ExactSpelling = true)]
            internal extern static void BindSamplers(UInt32 first, Int32 count, UInt32[] samplers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTexture", ExactSpelling = true)]
            internal extern static void BindTexture(klukule.OpenGL.TextureTarget target, UInt32 texture);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTextures", ExactSpelling = true)]
            internal extern static void BindTextures(UInt32 first, Int32 count, UInt32[] textures);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTextureUnit", ExactSpelling = true)]
            internal extern static void BindTextureUnit(UInt32 unit, UInt32 texture);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindTransformFeedback", ExactSpelling = true)]
            internal extern static void BindTransformFeedback(klukule.OpenGL.NvTransformFeedback2 target, UInt32 id);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindVertexArray", ExactSpelling = true)]
            internal extern static void BindVertexArray(UInt32 array);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindVertexBuffer", ExactSpelling = true)]
            internal extern static void BindVertexBuffer(UInt32 bindingindex, UInt32 buffer, IntPtr offset, IntPtr stride);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayVertexBuffer", ExactSpelling = true)]
            internal extern static void VertexArrayVertexBuffer(UInt32 vaobj, UInt32 bindingindex, UInt32 buffer, IntPtr offset, Int32 stride);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBindVertexBuffers", ExactSpelling = true)]
            internal extern static void BindVertexBuffers(UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayVertexBuffers", ExactSpelling = true)]
            internal extern static void VertexArrayVertexBuffers(UInt32 vaobj, UInt32 first, Int32 count, UInt32[] buffers, IntPtr[] offsets, Int32[] strides);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendColor", ExactSpelling = true)]
            internal extern static void BlendColor(Single red, Single green, Single blue, Single alpha);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquation", ExactSpelling = true)]
            internal extern static void BlendEquation(klukule.OpenGL.BlendEquationMode mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquationi", ExactSpelling = true)]
            internal extern static void BlendEquationi(UInt32 buf, klukule.OpenGL.BlendEquationMode mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquationSeparate", ExactSpelling = true)]
            internal extern static void BlendEquationSeparate(klukule.OpenGL.BlendEquationMode modeRGB, klukule.OpenGL.BlendEquationMode modeAlpha);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendEquationSeparatei", ExactSpelling = true)]
            internal extern static void BlendEquationSeparatei(UInt32 buf, klukule.OpenGL.BlendEquationMode modeRGB, klukule.OpenGL.BlendEquationMode modeAlpha);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFunc", ExactSpelling = true)]
            internal extern static void BlendFunc(klukule.OpenGL.BlendingFactorSrc sfactor, klukule.OpenGL.BlendingFactorDest dfactor);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFunci", ExactSpelling = true)]
            internal extern static void BlendFunci(UInt32 buf, klukule.OpenGL.BlendingFactorSrc sfactor, klukule.OpenGL.BlendingFactorDest dfactor);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFuncSeparate", ExactSpelling = true)]
            internal extern static void BlendFuncSeparate(klukule.OpenGL.BlendingFactorSrc srcRGB, klukule.OpenGL.BlendingFactorDest dstRGB, klukule.OpenGL.BlendingFactorSrc srcAlpha, klukule.OpenGL.BlendingFactorDest dstAlpha);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlendFuncSeparatei", ExactSpelling = true)]
            internal extern static void BlendFuncSeparatei(UInt32 buf, klukule.OpenGL.BlendingFactorSrc srcRGB, klukule.OpenGL.BlendingFactorDest dstRGB, klukule.OpenGL.BlendingFactorSrc srcAlpha, klukule.OpenGL.BlendingFactorDest dstAlpha);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlitFramebuffer", ExactSpelling = true)]
            internal extern static void BlitFramebuffer(Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, klukule.OpenGL.ClearBufferMask mask, klukule.OpenGL.BlitFramebufferFilter filter);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBlitNamedFramebuffer", ExactSpelling = true)]
            internal extern static void BlitNamedFramebuffer(UInt32 readFramebuffer, UInt32 drawFramebuffer, Int32 srcX0, Int32 srcY0, Int32 srcX1, Int32 srcY1, Int32 dstX0, Int32 dstY0, Int32 dstX1, Int32 dstY1, klukule.OpenGL.ClearBufferMask mask, klukule.OpenGL.BlitFramebufferFilter filter);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferData", ExactSpelling = true)]
            internal extern static void BufferData(klukule.OpenGL.BufferTarget target, IntPtr size, IntPtr data, klukule.OpenGL.BufferUsageHint usage);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedBufferData", ExactSpelling = true)]
            internal extern static void NamedBufferData(UInt32 buffer, Int32 size, IntPtr data, klukule.OpenGL.BufferUsageHint usage);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferStorage", ExactSpelling = true)]
            internal extern static void BufferStorage(klukule.OpenGL.BufferTarget target, IntPtr size, IntPtr data, UInt32 flags);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedBufferStorage", ExactSpelling = true)]
            internal extern static void NamedBufferStorage(UInt32 buffer, Int32 size, IntPtr data, UInt32 flags);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glBufferSubData", ExactSpelling = true)]
            internal extern static void BufferSubData(klukule.OpenGL.BufferTarget target, IntPtr offset, IntPtr size, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedBufferSubData", ExactSpelling = true)]
            internal extern static void NamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCheckFramebufferStatus", ExactSpelling = true)]
            internal extern static klukule.OpenGL.FramebufferErrorCode CheckFramebufferStatus(klukule.OpenGL.FramebufferTarget target);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCheckNamedFramebufferStatus", ExactSpelling = true)]
            internal extern static klukule.OpenGL.FramebufferErrorCode CheckNamedFramebufferStatus(UInt32 framebuffer, klukule.OpenGL.FramebufferTarget target);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClampColor", ExactSpelling = true)]
            internal extern static void ClampColor(klukule.OpenGL.ClampColorTarget target, klukule.OpenGL.ClampColorMode clamp);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClear", ExactSpelling = true)]
            internal extern static void Clear(klukule.OpenGL.ClearBufferMask mask);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearBufferiv", ExactSpelling = true)]
            internal extern static void ClearBufferiv(klukule.OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearBufferuiv", ExactSpelling = true)]
            internal extern static void ClearBufferuiv(klukule.OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearBufferfv", ExactSpelling = true)]
            internal extern static void ClearBufferfv(klukule.OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearBufferfi", ExactSpelling = true)]
            internal extern static void ClearBufferfi(klukule.OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single depth, Int32 stencil);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearNamedFramebufferiv", ExactSpelling = true)]
            internal extern static void ClearNamedFramebufferiv(UInt32 framebuffer, klukule.OpenGL.ClearBuffer buffer, Int32 drawbuffer, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearNamedFramebufferuiv", ExactSpelling = true)]
            internal extern static void ClearNamedFramebufferuiv(UInt32 framebuffer, klukule.OpenGL.ClearBuffer buffer, Int32 drawbuffer, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearNamedFramebufferfv", ExactSpelling = true)]
            internal extern static void ClearNamedFramebufferfv(UInt32 framebuffer, klukule.OpenGL.ClearBuffer buffer, Int32 drawbuffer, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearNamedFramebufferfi", ExactSpelling = true)]
            internal extern static void ClearNamedFramebufferfi(UInt32 framebuffer, klukule.OpenGL.ClearBuffer buffer, Single depth, Int32 stencil);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearBufferData", ExactSpelling = true)]
            internal extern static void ClearBufferData(klukule.OpenGL.BufferTarget target, klukule.OpenGL.SizedInternalFormat internalFormat, klukule.OpenGL.PixelInternalFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearNamedBufferData", ExactSpelling = true)]
            internal extern static void ClearNamedBufferData(UInt32 buffer, klukule.OpenGL.SizedInternalFormat internalFormat, klukule.OpenGL.PixelInternalFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearBufferSubData", ExactSpelling = true)]
            internal extern static void ClearBufferSubData(klukule.OpenGL.BufferTarget target, klukule.OpenGL.SizedInternalFormat internalFormat, IntPtr offset, IntPtr size, klukule.OpenGL.PixelInternalFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearNamedBufferSubData", ExactSpelling = true)]
            internal extern static void ClearNamedBufferSubData(UInt32 buffer, klukule.OpenGL.SizedInternalFormat internalFormat, IntPtr offset, Int32 size, klukule.OpenGL.PixelInternalFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearColor", ExactSpelling = true)]
            internal extern static void ClearColor(Single red, Single green, Single blue, Single alpha);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearDepth", ExactSpelling = true)]
            internal extern static void ClearDepth(Double depth);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearDepthf", ExactSpelling = true)]
            internal extern static void ClearDepthf(Single depth);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearStencil", ExactSpelling = true)]
            internal extern static void ClearStencil(Int32 s);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearTexImage", ExactSpelling = true)]
            internal extern static void ClearTexImage(UInt32 texture, Int32 level, klukule.OpenGL.PixelInternalFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClearTexSubImage", ExactSpelling = true)]
            internal extern static void ClearTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, klukule.OpenGL.PixelInternalFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClientWaitSync", ExactSpelling = true)]
            internal extern static klukule.OpenGL.ArbSync ClientWaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glClipControl", ExactSpelling = true)]
            internal extern static void ClipControl(klukule.OpenGL.ClipControlOrigin origin, klukule.OpenGL.ClipControlDepth depth);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorMask", ExactSpelling = true)]
            internal extern static void ColorMask(Boolean red, Boolean green, Boolean blue, Boolean alpha);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glColorMaski", ExactSpelling = true)]
            internal extern static void ColorMaski(UInt32 buf, Boolean red, Boolean green, Boolean blue, Boolean alpha);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompileShader", ExactSpelling = true)]
            internal extern static void CompileShader(UInt32 shader);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage1D", ExactSpelling = true)]
            internal extern static void CompressedTexImage1D(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexImage2D(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexImage3D", ExactSpelling = true)]
            internal extern static void CompressedTexImage3D(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage1D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage1D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, klukule.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage1D", ExactSpelling = true)]
            internal extern static void CompressedTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, klukule.OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage2D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, klukule.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage2D", ExactSpelling = true)]
            internal extern static void CompressedTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, klukule.OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTexSubImage3D", ExactSpelling = true)]
            internal extern static void CompressedTexSubImage3D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, klukule.OpenGL.PixelFormat format, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCompressedTextureSubImage3D", ExactSpelling = true)]
            internal extern static void CompressedTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, klukule.OpenGL.PixelInternalFormat format, Int32 imageSize, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyBufferSubData", ExactSpelling = true)]
            internal extern static void CopyBufferSubData(klukule.OpenGL.BufferTarget readTarget, klukule.OpenGL.BufferTarget writeTarget, IntPtr readOffset, IntPtr writeOffset, IntPtr size);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyNamedBufferSubData", ExactSpelling = true)]
            internal extern static void CopyNamedBufferSubData(UInt32 readBuffer, UInt32 writeBuffer, IntPtr readOffset, IntPtr writeOffset, Int32 size);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyImageSubData", ExactSpelling = true)]
            internal extern static void CopyImageSubData(UInt32 srcName, klukule.OpenGL.BufferTarget srcTarget, Int32 srcLevel, Int32 srcX, Int32 srcY, Int32 srcZ, UInt32 dstName, klukule.OpenGL.BufferTarget dstTarget, Int32 dstLevel, Int32 dstX, Int32 dstY, Int32 dstZ, Int32 srcWidth, Int32 srcHeight, Int32 srcDepth);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexImage1D", ExactSpelling = true)]
            internal extern static void CopyTexImage1D(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 border);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexImage2D", ExactSpelling = true)]
            internal extern static void CopyTexImage2D(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 x, Int32 y, Int32 width, Int32 height, Int32 border);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage1D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage1D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTextureSubImage1D", ExactSpelling = true)]
            internal extern static void CopyTextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 x, Int32 y, Int32 width);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage2D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTextureSubImage2D", ExactSpelling = true)]
            internal extern static void CopyTextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTexSubImage3D", ExactSpelling = true)]
            internal extern static void CopyTexSubImage3D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCopyTextureSubImage3D", ExactSpelling = true)]
            internal extern static void CopyTextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateBuffers", ExactSpelling = true)]
            internal extern static void CreateBuffers(Int32 n, UInt32[] buffers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateFramebuffers", ExactSpelling = true)]
            internal extern static void CreateFramebuffers(Int32 n, UInt32[] ids);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateProgram", ExactSpelling = true)]
            internal extern static UInt32 CreateProgram();
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateProgramPipelines", ExactSpelling = true)]
            internal extern static void CreateProgramPipelines(Int32 n, UInt32[] pipelines);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateQueries", ExactSpelling = true)]
            internal extern static void CreateQueries(klukule.OpenGL.QueryTarget target, Int32 n, UInt32[] ids);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateRenderbuffers", ExactSpelling = true)]
            internal extern static void CreateRenderbuffers(Int32 n, UInt32[] renderbuffers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateSamplers", ExactSpelling = true)]
            internal extern static void CreateSamplers(Int32 n, UInt32[] samplers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateShader", ExactSpelling = true)]
            internal extern static UInt32 CreateShader(klukule.OpenGL.ShaderType shaderType);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateShaderProgramv", ExactSpelling = true)]
            internal extern static UInt32 CreateShaderProgramv(klukule.OpenGL.ShaderType type, Int32 count, String strings);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateTextures", ExactSpelling = true)]
            internal extern static void CreateTextures(klukule.OpenGL.TextureTarget target, Int32 n, UInt32[] textures);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateTransformFeedbacks", ExactSpelling = true)]
            internal extern static void CreateTransformFeedbacks(Int32 n, UInt32[] ids);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCreateVertexArrays", ExactSpelling = true)]
            internal extern static void CreateVertexArrays(Int32 n, UInt32[] arrays);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glCullFace", ExactSpelling = true)]
            internal extern static void CullFace(klukule.OpenGL.CullFaceMode mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteBuffers", ExactSpelling = true)]
            internal extern static void DeleteBuffers(Int32 n, UInt32[] buffers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteFramebuffers", ExactSpelling = true)]
            internal extern static void DeleteFramebuffers(Int32 n, UInt32[] framebuffers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteProgram", ExactSpelling = true)]
            internal extern static void DeleteProgram(UInt32 program);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteProgramPipelines", ExactSpelling = true)]
            internal extern static void DeleteProgramPipelines(Int32 n, UInt32[] pipelines);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteQueries", ExactSpelling = true)]
            internal extern static void DeleteQueries(Int32 n, UInt32[] ids);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteRenderbuffers", ExactSpelling = true)]
            internal extern static void DeleteRenderbuffers(Int32 n, UInt32[] renderbuffers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteSamplers", ExactSpelling = true)]
            internal extern static void DeleteSamplers(Int32 n, UInt32[] samplers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteShader", ExactSpelling = true)]
            internal extern static void DeleteShader(UInt32 shader);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteSync", ExactSpelling = true)]
            internal extern static void DeleteSync(IntPtr sync);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteTextures", ExactSpelling = true)]
            internal extern static void DeleteTextures(Int32 n, UInt32[] textures);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteTransformFeedbacks", ExactSpelling = true)]
            internal extern static void DeleteTransformFeedbacks(Int32 n, UInt32[] ids);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDeleteVertexArrays", ExactSpelling = true)]
            internal extern static void DeleteVertexArrays(Int32 n, UInt32[] arrays);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthFunc", ExactSpelling = true)]
            internal extern static void DepthFunc(klukule.OpenGL.DepthFunction func);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthMask", ExactSpelling = true)]
            internal extern static void DepthMask(Boolean flag);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthRange", ExactSpelling = true)]
            internal extern static void DepthRange(Double nearVal, Double farVal);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthRangef", ExactSpelling = true)]
            internal extern static void DepthRangef(Single nearVal, Single farVal);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthRangeArrayv", ExactSpelling = true)]
            internal extern static void DepthRangeArrayv(UInt32 first, Int32 count, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDepthRangeIndexed", ExactSpelling = true)]
            internal extern static void DepthRangeIndexed(UInt32 index, Double nearVal, Double farVal);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDetachShader", ExactSpelling = true)]
            internal extern static void DetachShader(UInt32 program, UInt32 shader);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDispatchCompute", ExactSpelling = true)]
            internal extern static void DispatchCompute(UInt32 num_groups_x, UInt32 num_groups_y, UInt32 num_groups_z);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDispatchComputeIndirect", ExactSpelling = true)]
            internal extern static void DispatchComputeIndirect(IntPtr indirect);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawArrays", ExactSpelling = true)]
            internal extern static void DrawArrays(klukule.OpenGL.BeginMode mode, Int32 first, Int32 count);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawArraysIndirect", ExactSpelling = true)]
            internal extern static void DrawArraysIndirect(klukule.OpenGL.BeginMode mode, IntPtr indirect);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawArraysInstanced", ExactSpelling = true)]
            internal extern static void DrawArraysInstanced(klukule.OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawArraysInstancedBaseInstance", ExactSpelling = true)]
            internal extern static void DrawArraysInstancedBaseInstance(klukule.OpenGL.BeginMode mode, Int32 first, Int32 count, Int32 primcount, UInt32 baseinstance);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawBuffer", ExactSpelling = true)]
            internal extern static void DrawBuffer(klukule.OpenGL.DrawBufferMode buf);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedFramebufferDrawBuffer", ExactSpelling = true)]
            internal extern static void NamedFramebufferDrawBuffer(UInt32 framebuffer, klukule.OpenGL.DrawBufferMode buf);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawBuffers", ExactSpelling = true)]
            internal extern static void DrawBuffers(Int32 n, klukule.OpenGL.DrawBuffersEnum[] bufs);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedFramebufferDrawBuffers", ExactSpelling = true)]
            internal extern static void NamedFramebufferDrawBuffers(UInt32 framebuffer, Int32 n, klukule.OpenGL.DrawBufferMode[] bufs);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElements", ExactSpelling = true)]
            internal extern static void DrawElements(klukule.OpenGL.BeginMode mode, Int32 count, klukule.OpenGL.DrawElementsType type, IntPtr indices);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementsBaseVertex", ExactSpelling = true)]
            internal extern static void DrawElementsBaseVertex(klukule.OpenGL.BeginMode mode, Int32 count, klukule.OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementsIndirect", ExactSpelling = true)]
            internal extern static void DrawElementsIndirect(klukule.OpenGL.BeginMode mode, klukule.OpenGL.DrawElementsType type, IntPtr indirect);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementsInstanced", ExactSpelling = true)]
            internal extern static void DrawElementsInstanced(klukule.OpenGL.BeginMode mode, Int32 count, klukule.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseInstance", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedBaseInstance(klukule.OpenGL.BeginMode mode, Int32 count, klukule.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, UInt32 baseinstance);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseVertex", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedBaseVertex(klukule.OpenGL.BeginMode mode, Int32 count, klukule.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawElementsInstancedBaseVertexBaseInstance", ExactSpelling = true)]
            internal extern static void DrawElementsInstancedBaseVertexBaseInstance(klukule.OpenGL.BeginMode mode, Int32 count, klukule.OpenGL.DrawElementsType type, IntPtr indices, Int32 primcount, Int32 basevertex, UInt32 baseinstance);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawRangeElements", ExactSpelling = true)]
            internal extern static void DrawRangeElements(klukule.OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, klukule.OpenGL.DrawElementsType type, IntPtr indices);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawRangeElementsBaseVertex", ExactSpelling = true)]
            internal extern static void DrawRangeElementsBaseVertex(klukule.OpenGL.BeginMode mode, UInt32 start, UInt32 end, Int32 count, klukule.OpenGL.DrawElementsType type, IntPtr indices, Int32 basevertex);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawTransformFeedback", ExactSpelling = true)]
            internal extern static void DrawTransformFeedback(klukule.OpenGL.NvTransformFeedback2 mode, UInt32 id);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackInstanced", ExactSpelling = true)]
            internal extern static void DrawTransformFeedbackInstanced(klukule.OpenGL.BeginMode mode, UInt32 id, Int32 primcount);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackStream", ExactSpelling = true)]
            internal extern static void DrawTransformFeedbackStream(klukule.OpenGL.NvTransformFeedback2 mode, UInt32 id, UInt32 stream);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDrawTransformFeedbackStreamInstanced", ExactSpelling = true)]
            internal extern static void DrawTransformFeedbackStreamInstanced(klukule.OpenGL.BeginMode mode, UInt32 id, UInt32 stream, Int32 primcount);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnable", ExactSpelling = true)]
            internal extern static void Enable(klukule.OpenGL.EnableCap cap);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisable", ExactSpelling = true)]
            internal extern static void Disable(klukule.OpenGL.EnableCap cap);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnablei", ExactSpelling = true)]
            internal extern static void Enablei(klukule.OpenGL.EnableCap cap, UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisablei", ExactSpelling = true)]
            internal extern static void Disablei(klukule.OpenGL.EnableCap cap, UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableVertexAttribArray", ExactSpelling = true)]
            internal extern static void EnableVertexAttribArray(UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableVertexAttribArray", ExactSpelling = true)]
            internal extern static void DisableVertexAttribArray(UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glEnableVertexArrayAttrib", ExactSpelling = true)]
            internal extern static void EnableVertexArrayAttrib(UInt32 vaobj, UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glDisableVertexArrayAttrib", ExactSpelling = true)]
            internal extern static void DisableVertexArrayAttrib(UInt32 vaobj, UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFenceSync", ExactSpelling = true)]
            internal extern static IntPtr FenceSync(klukule.OpenGL.ArbSync condition, UInt32 flags);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFinish", ExactSpelling = true)]
            internal extern static void Finish();
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlush", ExactSpelling = true)]
            internal extern static void Flush();
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlushMappedBufferRange", ExactSpelling = true)]
            internal extern static void FlushMappedBufferRange(klukule.OpenGL.BufferTarget target, IntPtr offset, IntPtr length);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFlushMappedNamedBufferRange", ExactSpelling = true)]
            internal extern static void FlushMappedNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferParameteri", ExactSpelling = true)]
            internal extern static void FramebufferParameteri(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferPName pname, Int32 param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedFramebufferParameteri", ExactSpelling = true)]
            internal extern static void NamedFramebufferParameteri(UInt32 framebuffer, klukule.OpenGL.FramebufferPName pname, Int32 param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferRenderbuffer", ExactSpelling = true)]
            internal extern static void FramebufferRenderbuffer(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferAttachment attachment, klukule.OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedFramebufferRenderbuffer", ExactSpelling = true)]
            internal extern static void NamedFramebufferRenderbuffer(UInt32 framebuffer, klukule.OpenGL.FramebufferAttachment attachment, klukule.OpenGL.RenderbufferTarget renderbuffertarget, UInt32 renderbuffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTexture", ExactSpelling = true)]
            internal extern static void FramebufferTexture(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTexture1D", ExactSpelling = true)]
            internal extern static void FramebufferTexture1D(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferAttachment attachment, klukule.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTexture2D", ExactSpelling = true)]
            internal extern static void FramebufferTexture2D(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferAttachment attachment, klukule.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTexture3D", ExactSpelling = true)]
            internal extern static void FramebufferTexture3D(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferAttachment attachment, klukule.OpenGL.TextureTarget textarget, UInt32 texture, Int32 level, Int32 layer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedFramebufferTexture", ExactSpelling = true)]
            internal extern static void NamedFramebufferTexture(UInt32 framebuffer, klukule.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFramebufferTextureLayer", ExactSpelling = true)]
            internal extern static void FramebufferTextureLayer(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedFramebufferTextureLayer", ExactSpelling = true)]
            internal extern static void NamedFramebufferTextureLayer(UInt32 framebuffer, klukule.OpenGL.FramebufferAttachment attachment, UInt32 texture, Int32 level, Int32 layer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glFrontFace", ExactSpelling = true)]
            internal extern static void FrontFace(klukule.OpenGL.FrontFaceDirection mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenBuffers", ExactSpelling = true)]
            internal extern static void GenBuffers(Int32 n, [OutAttribute] UInt32[] buffers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenerateMipmap", ExactSpelling = true)]
            internal extern static void GenerateMipmap(klukule.OpenGL.GenerateMipmapTarget target);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenerateTextureMipmap", ExactSpelling = true)]
            internal extern static void GenerateTextureMipmap(UInt32 texture);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenFramebuffers", ExactSpelling = true)]
            internal extern static void GenFramebuffers(Int32 n, [OutAttribute] UInt32[] ids);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenProgramPipelines", ExactSpelling = true)]
            internal extern static void GenProgramPipelines(Int32 n, [OutAttribute] UInt32[] pipelines);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenQueries", ExactSpelling = true)]
            internal extern static void GenQueries(Int32 n, [OutAttribute] UInt32[] ids);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenRenderbuffers", ExactSpelling = true)]
            internal extern static void GenRenderbuffers(Int32 n, [OutAttribute] UInt32[] renderbuffers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenSamplers", ExactSpelling = true)]
            internal extern static void GenSamplers(Int32 n, [OutAttribute] UInt32[] samplers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenTextures", ExactSpelling = true)]
            internal extern static void GenTextures(Int32 n, [OutAttribute] UInt32[] textures);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenTransformFeedbacks", ExactSpelling = true)]
            internal extern static void GenTransformFeedbacks(Int32 n, [OutAttribute] UInt32[] ids);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGenVertexArrays", ExactSpelling = true)]
            internal extern static void GenVertexArrays(Int32 n, [OutAttribute] UInt32[] arrays);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBooleanv", ExactSpelling = true)]
            internal extern static void GetBooleanv(klukule.OpenGL.GetPName pname, [OutAttribute] Boolean[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetDoublev", ExactSpelling = true)]
            internal extern static void GetDoublev(klukule.OpenGL.GetPName pname, [OutAttribute] Double[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFloatv", ExactSpelling = true)]
            internal extern static void GetFloatv(klukule.OpenGL.GetPName pname, [OutAttribute] Single[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetIntegerv", ExactSpelling = true)]
            internal extern static void GetIntegerv(klukule.OpenGL.GetPName pname, [OutAttribute] Int32[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInteger64v", ExactSpelling = true)]
            internal extern static void GetInteger64v(klukule.OpenGL.ArbSync pname, [OutAttribute] Int64[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBooleani_v", ExactSpelling = true)]
            internal extern static void GetBooleani_v(klukule.OpenGL.GetPName target, UInt32 index, [OutAttribute] Boolean[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetIntegeri_v", ExactSpelling = true)]
            internal extern static void GetIntegeri_v(klukule.OpenGL.GetPName target, UInt32 index, [OutAttribute] Int32[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFloati_v", ExactSpelling = true)]
            internal extern static void GetFloati_v(klukule.OpenGL.GetPName target, UInt32 index, [OutAttribute] Single[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetDoublei_v", ExactSpelling = true)]
            internal extern static void GetDoublei_v(klukule.OpenGL.GetPName target, UInt32 index, [OutAttribute] Double[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInteger64i_v", ExactSpelling = true)]
            internal extern static void GetInteger64i_v(klukule.OpenGL.GetPName target, UInt32 index, [OutAttribute] Int64[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveAtomicCounterBufferiv", ExactSpelling = true)]
            internal extern static void GetActiveAtomicCounterBufferiv(UInt32 program, UInt32 bufferIndex, klukule.OpenGL.AtomicCounterParameterName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveAttrib", ExactSpelling = true)]
            internal extern static void GetActiveAttrib(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] klukule.OpenGL.ActiveAttribType[] type, [OutAttribute] System.Text.StringBuilder name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveSubroutineName", ExactSpelling = true)]
            internal extern static void GetActiveSubroutineName(UInt32 program, klukule.OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveSubroutineUniformiv", ExactSpelling = true)]
            internal extern static void GetActiveSubroutineUniformiv(UInt32 program, klukule.OpenGL.ShaderType shadertype, UInt32 index, klukule.OpenGL.SubroutineParameterName pname, [OutAttribute] Int32[] values);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveSubroutineUniformName", ExactSpelling = true)]
            internal extern static void GetActiveSubroutineUniformName(UInt32 program, klukule.OpenGL.ShaderType shadertype, UInt32 index, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveUniform", ExactSpelling = true)]
            internal extern static void GetActiveUniform(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] klukule.OpenGL.ActiveUniformType[] type, [OutAttribute] System.Text.StringBuilder name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveUniformBlockiv", ExactSpelling = true)]
            internal extern static void GetActiveUniformBlockiv(UInt32 program, UInt32 uniformBlockIndex, klukule.OpenGL.ActiveUniformBlockParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveUniformBlockName", ExactSpelling = true)]
            internal extern static void GetActiveUniformBlockName(UInt32 program, UInt32 uniformBlockIndex, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder uniformBlockName);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveUniformName", ExactSpelling = true)]
            internal extern static void GetActiveUniformName(UInt32 program, UInt32 uniformIndex, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder uniformName);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetActiveUniformsiv", ExactSpelling = true)]
            internal extern static void GetActiveUniformsiv(UInt32 program, Int32 uniformCount, [OutAttribute] UInt32[] uniformIndices, klukule.OpenGL.ActiveUniformType pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetAttachedShaders", ExactSpelling = true)]
            internal extern static void GetAttachedShaders(UInt32 program, Int32 maxCount, [OutAttribute] Int32[] count, [OutAttribute] UInt32[] shaders);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetAttribLocation", ExactSpelling = true)]
            internal extern static Int32 GetAttribLocation(UInt32 program, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferParameteriv", ExactSpelling = true)]
            internal extern static void GetBufferParameteriv(klukule.OpenGL.BufferTarget target, klukule.OpenGL.BufferParameterName value, [OutAttribute] Int32[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferParameteri64v", ExactSpelling = true)]
            internal extern static void GetBufferParameteri64v(klukule.OpenGL.BufferTarget target, klukule.OpenGL.BufferParameterName value, [OutAttribute] Int64[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetNamedBufferParameteriv", ExactSpelling = true)]
            internal extern static void GetNamedBufferParameteriv(UInt32 buffer, klukule.OpenGL.BufferParameterName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetNamedBufferParameteri64v", ExactSpelling = true)]
            internal extern static void GetNamedBufferParameteri64v(UInt32 buffer, klukule.OpenGL.BufferParameterName pname, [OutAttribute] Int64[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferPointerv", ExactSpelling = true)]
            internal extern static void GetBufferPointerv(klukule.OpenGL.BufferTarget target, klukule.OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetNamedBufferPointerv", ExactSpelling = true)]
            internal extern static void GetNamedBufferPointerv(UInt32 buffer, klukule.OpenGL.BufferPointer pname, [OutAttribute] IntPtr @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetBufferSubData", ExactSpelling = true)]
            internal extern static void GetBufferSubData(klukule.OpenGL.BufferTarget target, IntPtr offset, IntPtr size, [OutAttribute] IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetNamedBufferSubData", ExactSpelling = true)]
            internal extern static void GetNamedBufferSubData(UInt32 buffer, IntPtr offset, Int32 size, [OutAttribute] IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCompressedTexImage", ExactSpelling = true)]
            internal extern static void GetCompressedTexImage(klukule.OpenGL.TextureTarget target, Int32 level, [OutAttribute] IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetnCompressedTexImage", ExactSpelling = true)]
            internal extern static void GetnCompressedTexImage(klukule.OpenGL.TextureTarget target, Int32 level, Int32 bufSize, [OutAttribute] IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCompressedTextureImage", ExactSpelling = true)]
            internal extern static void GetCompressedTextureImage(UInt32 texture, Int32 level, Int32 bufSize, [OutAttribute] IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetCompressedTextureSubImage", ExactSpelling = true)]
            internal extern static void GetCompressedTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, Int32 bufSize, [OutAttribute] IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetError", ExactSpelling = true)]
            internal extern static klukule.OpenGL.ErrorCode GetError();
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFragDataIndex", ExactSpelling = true)]
            internal extern static Int32 GetFragDataIndex(UInt32 program, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFragDataLocation", ExactSpelling = true)]
            internal extern static Int32 GetFragDataLocation(UInt32 program, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFramebufferAttachmentParameteriv", ExactSpelling = true)]
            internal extern static void GetFramebufferAttachmentParameteriv(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferAttachment attachment, klukule.OpenGL.FramebufferParameterName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetNamedFramebufferAttachmentParameteriv", ExactSpelling = true)]
            internal extern static void GetNamedFramebufferAttachmentParameteriv(UInt32 framebuffer, klukule.OpenGL.FramebufferAttachment attachment, klukule.OpenGL.FramebufferParameterName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetFramebufferParameteriv", ExactSpelling = true)]
            internal extern static void GetFramebufferParameteriv(klukule.OpenGL.FramebufferTarget target, klukule.OpenGL.FramebufferPName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetNamedFramebufferParameteriv", ExactSpelling = true)]
            internal extern static void GetNamedFramebufferParameteriv(UInt32 framebuffer, klukule.OpenGL.FramebufferPName pname, [OutAttribute] Int32[] param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetGraphicsResetStatus", ExactSpelling = true)]
            internal extern static klukule.OpenGL.GraphicResetStatus GetGraphicsResetStatus();
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInternalformativ", ExactSpelling = true)]
            internal extern static void GetInternalformativ(klukule.OpenGL.TextureTarget target, klukule.OpenGL.PixelInternalFormat internalFormat, klukule.OpenGL.GetPName pname, Int32 bufSize, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetInternalformati64v", ExactSpelling = true)]
            internal extern static void GetInternalformati64v(klukule.OpenGL.TextureTarget target, klukule.OpenGL.PixelInternalFormat internalFormat, klukule.OpenGL.GetPName pname, Int32 bufSize, [OutAttribute] Int64[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetMultisamplefv", ExactSpelling = true)]
            internal extern static void GetMultisamplefv(klukule.OpenGL.GetMultisamplePName pname, UInt32 index, [OutAttribute] Single[] val);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetObjectLabel", ExactSpelling = true)]
            internal extern static void GetObjectLabel(klukule.OpenGL.ObjectLabel identifier, UInt32 name, Int32 bifSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder label);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetObjectPtrLabel", ExactSpelling = true)]
            internal extern static void GetObjectPtrLabel([OutAttribute] IntPtr ptr, Int32 bifSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder label);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetPointerv", ExactSpelling = true)]
            internal extern static void GetPointerv(klukule.OpenGL.GetPointerParameter pname, [OutAttribute] IntPtr @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramiv", ExactSpelling = true)]
            internal extern static void GetProgramiv(UInt32 program, klukule.OpenGL.ProgramParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramBinary", ExactSpelling = true)]
            internal extern static void GetProgramBinary(UInt32 program, Int32 bufsize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] binaryFormat, [OutAttribute] IntPtr binary);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramInfoLog", ExactSpelling = true)]
            internal extern static void GetProgramInfoLog(UInt32 program, Int32 maxLength, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramInterfaceiv", ExactSpelling = true)]
            internal extern static void GetProgramInterfaceiv(UInt32 program, klukule.OpenGL.ProgramInterface programInterface, klukule.OpenGL.ProgramInterfaceParameterName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramPipelineiv", ExactSpelling = true)]
            internal extern static void GetProgramPipelineiv(UInt32 pipeline, Int32 pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramPipelineInfoLog", ExactSpelling = true)]
            internal extern static void GetProgramPipelineInfoLog(UInt32 pipeline, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramResourceiv", ExactSpelling = true)]
            internal extern static void GetProgramResourceiv(UInt32 program, klukule.OpenGL.ProgramInterface programInterface, UInt32 index, Int32 propCount, [OutAttribute] klukule.OpenGL.ProgramResourceParameterName[] props, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramResourceIndex", ExactSpelling = true)]
            internal extern static UInt32 GetProgramResourceIndex(UInt32 program, klukule.OpenGL.ProgramInterface programInterface, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramResourceLocation", ExactSpelling = true)]
            internal extern static Int32 GetProgramResourceLocation(UInt32 program, klukule.OpenGL.ProgramInterface programInterface, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramResourceLocationIndex", ExactSpelling = true)]
            internal extern static Int32 GetProgramResourceLocationIndex(UInt32 program, klukule.OpenGL.ProgramInterface programInterface, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramResourceName", ExactSpelling = true)]
            internal extern static void GetProgramResourceName(UInt32 program, klukule.OpenGL.ProgramInterface programInterface, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetProgramStageiv", ExactSpelling = true)]
            internal extern static void GetProgramStageiv(UInt32 program, klukule.OpenGL.ShaderType shadertype, klukule.OpenGL.ProgramStageParameterName pname, [OutAttribute] Int32[] values);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryIndexediv", ExactSpelling = true)]
            internal extern static void GetQueryIndexediv(klukule.OpenGL.QueryTarget target, UInt32 index, klukule.OpenGL.GetQueryParam pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryiv", ExactSpelling = true)]
            internal extern static void GetQueryiv(klukule.OpenGL.QueryTarget target, klukule.OpenGL.GetQueryParam pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectiv", ExactSpelling = true)]
            internal extern static void GetQueryObjectiv(UInt32 id, klukule.OpenGL.GetQueryObjectParam pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectuiv", ExactSpelling = true)]
            internal extern static void GetQueryObjectuiv(UInt32 id, klukule.OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjecti64v", ExactSpelling = true)]
            internal extern static void GetQueryObjecti64v(UInt32 id, klukule.OpenGL.GetQueryObjectParam pname, [OutAttribute] Int64[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetQueryObjectui64v", ExactSpelling = true)]
            internal extern static void GetQueryObjectui64v(UInt32 id, klukule.OpenGL.GetQueryObjectParam pname, [OutAttribute] UInt64[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetRenderbufferParameteriv", ExactSpelling = true)]
            internal extern static void GetRenderbufferParameteriv(klukule.OpenGL.RenderbufferTarget target, klukule.OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetNamedRenderbufferParameteriv", ExactSpelling = true)]
            internal extern static void GetNamedRenderbufferParameteriv(UInt32 renderbuffer, klukule.OpenGL.RenderbufferParameterName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSamplerParameterfv", ExactSpelling = true)]
            internal extern static void GetSamplerParameterfv(UInt32 sampler, Int32 pname, [OutAttribute] Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSamplerParameteriv", ExactSpelling = true)]
            internal extern static void GetSamplerParameteriv(UInt32 sampler, Int32 pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSamplerParameterIiv", ExactSpelling = true)]
            internal extern static void GetSamplerParameterIiv(UInt32 sampler, klukule.OpenGL.TextureParameterName pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSamplerParameterIuiv", ExactSpelling = true)]
            internal extern static void GetSamplerParameterIuiv(UInt32 sampler, klukule.OpenGL.TextureParameterName pname, [OutAttribute] UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderiv", ExactSpelling = true)]
            internal extern static void GetShaderiv(UInt32 shader, klukule.OpenGL.ShaderParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderInfoLog", ExactSpelling = true)]
            internal extern static void GetShaderInfoLog(UInt32 shader, Int32 maxLength, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder infoLog);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderPrecisionFormat", ExactSpelling = true)]
            internal extern static void GetShaderPrecisionFormat(klukule.OpenGL.ShaderType shaderType, Int32 precisionType, [OutAttribute] Int32[] range, [OutAttribute] Int32[] precision);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetShaderSource", ExactSpelling = true)]
            internal extern static void GetShaderSource(UInt32 shader, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] System.Text.StringBuilder source);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetString", ExactSpelling = true)]
            internal extern static IntPtr GetString(klukule.OpenGL.StringName name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetStringi", ExactSpelling = true)]
            internal extern static IntPtr GetStringi(klukule.OpenGL.StringName name, UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSubroutineIndex", ExactSpelling = true)]
            internal extern static UInt32 GetSubroutineIndex(UInt32 program, klukule.OpenGL.ShaderType shadertype, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSubroutineUniformLocation", ExactSpelling = true)]
            internal extern static Int32 GetSubroutineUniformLocation(UInt32 program, klukule.OpenGL.ShaderType shadertype, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetSynciv", ExactSpelling = true)]
            internal extern static void GetSynciv(IntPtr sync, klukule.OpenGL.ArbSync pname, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] values);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexImage", ExactSpelling = true)]
            internal extern static void GetTexImage(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, [OutAttribute] IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetnTexImage", ExactSpelling = true)]
            internal extern static void GetnTexImage(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTextureImage", ExactSpelling = true)]
            internal extern static void GetTextureImage(UInt32 texture, Int32 level, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexLevelParameterfv", ExactSpelling = true)]
            internal extern static void GetTexLevelParameterfv(klukule.OpenGL.GetPName target, Int32 level, klukule.OpenGL.GetTextureLevelParameter pname, [OutAttribute] Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexLevelParameteriv", ExactSpelling = true)]
            internal extern static void GetTexLevelParameteriv(klukule.OpenGL.GetPName target, Int32 level, klukule.OpenGL.GetTextureLevelParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTextureLevelParameterfv", ExactSpelling = true)]
            internal extern static void GetTextureLevelParameterfv(UInt32 texture, Int32 level, klukule.OpenGL.GetTextureLevelParameter pname, [OutAttribute] Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTextureLevelParameteriv", ExactSpelling = true)]
            internal extern static void GetTextureLevelParameteriv(UInt32 texture, Int32 level, klukule.OpenGL.GetTextureLevelParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameterfv", ExactSpelling = true)]
            internal extern static void GetTexParameterfv(klukule.OpenGL.TextureTarget target, klukule.OpenGL.GetTextureParameter pname, [OutAttribute] Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameteriv", ExactSpelling = true)]
            internal extern static void GetTexParameteriv(klukule.OpenGL.TextureTarget target, klukule.OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameterIiv", ExactSpelling = true)]
            internal extern static void GetTexParameterIiv(klukule.OpenGL.TextureTarget target, klukule.OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTexParameterIuiv", ExactSpelling = true)]
            internal extern static void GetTexParameterIuiv(klukule.OpenGL.TextureTarget target, klukule.OpenGL.GetTextureParameter pname, [OutAttribute] UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTextureParameterfv", ExactSpelling = true)]
            internal extern static void GetTextureParameterfv(UInt32 texture, klukule.OpenGL.GetTextureParameter pname, [OutAttribute] Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTextureParameteriv", ExactSpelling = true)]
            internal extern static void GetTextureParameteriv(UInt32 texture, klukule.OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTextureParameterIiv", ExactSpelling = true)]
            internal extern static void GetTextureParameterIiv(UInt32 texture, klukule.OpenGL.GetTextureParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTextureParameterIuiv", ExactSpelling = true)]
            internal extern static void GetTextureParameterIuiv(UInt32 texture, klukule.OpenGL.GetTextureParameter pname, [OutAttribute] UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTextureSubImage", ExactSpelling = true)]
            internal extern static void GetTextureSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, Int32 bufSize, [OutAttribute] IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbackiv", ExactSpelling = true)]
            internal extern static void GetTransformFeedbackiv(UInt32 xfb, klukule.OpenGL.TransformFeedbackParameterName pname, [OutAttribute] Int32[] param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbacki_v", ExactSpelling = true)]
            internal extern static void GetTransformFeedbacki_v(UInt32 xfb, klukule.OpenGL.TransformFeedbackParameterName pname, UInt32 index, [OutAttribute] Int32[] param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbacki64_v", ExactSpelling = true)]
            internal extern static void GetTransformFeedbacki64_v(UInt32 xfb, klukule.OpenGL.TransformFeedbackParameterName pname, UInt32 index, [OutAttribute] Int64[] param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetTransformFeedbackVarying", ExactSpelling = true)]
            internal extern static void GetTransformFeedbackVarying(UInt32 program, UInt32 index, Int32 bufSize, [OutAttribute] Int32[] length, [OutAttribute] Int32[] size, [OutAttribute] klukule.OpenGL.ActiveAttribType[] type, [OutAttribute] System.Text.StringBuilder name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformfv", ExactSpelling = true)]
            internal extern static void GetUniformfv(UInt32 program, Int32 location, [OutAttribute] Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformiv", ExactSpelling = true)]
            internal extern static void GetUniformiv(UInt32 program, Int32 location, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformuiv", ExactSpelling = true)]
            internal extern static void GetUniformuiv(UInt32 program, Int32 location, [OutAttribute] UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformdv", ExactSpelling = true)]
            internal extern static void GetUniformdv(UInt32 program, Int32 location, [OutAttribute] Double[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetnUniformfv", ExactSpelling = true)]
            internal extern static void GetnUniformfv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetnUniformiv", ExactSpelling = true)]
            internal extern static void GetnUniformiv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetnUniformuiv", ExactSpelling = true)]
            internal extern static void GetnUniformuiv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetnUniformdv", ExactSpelling = true)]
            internal extern static void GetnUniformdv(UInt32 program, Int32 location, Int32 bufSize, [OutAttribute] Double[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformBlockIndex", ExactSpelling = true)]
            internal extern static UInt32 GetUniformBlockIndex(UInt32 program, String uniformBlockName);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformIndices", ExactSpelling = true)]
            internal extern static void GetUniformIndices(UInt32 program, Int32 uniformCount, String uniformNames, [OutAttribute] UInt32[] uniformIndices);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformLocation", ExactSpelling = true)]
            internal extern static Int32 GetUniformLocation(UInt32 program, String name);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetUniformSubroutineuiv", ExactSpelling = true)]
            internal extern static void GetUniformSubroutineuiv(klukule.OpenGL.ShaderType shadertype, Int32 location, [OutAttribute] UInt32[] values);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexArrayIndexed64iv", ExactSpelling = true)]
            internal extern static void GetVertexArrayIndexed64iv(UInt32 vaobj, UInt32 index, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] Int64[] param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexArrayIndexediv", ExactSpelling = true)]
            internal extern static void GetVertexArrayIndexediv(UInt32 vaobj, UInt32 index, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexArrayiv", ExactSpelling = true)]
            internal extern static void GetVertexArrayiv(UInt32 vaobj, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribdv", ExactSpelling = true)]
            internal extern static void GetVertexAttribdv(UInt32 index, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] Double[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribfv", ExactSpelling = true)]
            internal extern static void GetVertexAttribfv(UInt32 index, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribiv", ExactSpelling = true)]
            internal extern static void GetVertexAttribiv(UInt32 index, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribIiv", ExactSpelling = true)]
            internal extern static void GetVertexAttribIiv(UInt32 index, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribIuiv", ExactSpelling = true)]
            internal extern static void GetVertexAttribIuiv(UInt32 index, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribLdv", ExactSpelling = true)]
            internal extern static void GetVertexAttribLdv(UInt32 index, klukule.OpenGL.VertexAttribParameter pname, [OutAttribute] Double[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glGetVertexAttribPointerv", ExactSpelling = true)]
            internal extern static void GetVertexAttribPointerv(UInt32 index, klukule.OpenGL.VertexAttribPointerParameter pname, [OutAttribute] IntPtr pointer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glHint", ExactSpelling = true)]
            internal extern static void Hint(klukule.OpenGL.HintTarget target, klukule.OpenGL.HintMode mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInvalidateBufferData", ExactSpelling = true)]
            internal extern static void InvalidateBufferData(UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInvalidateBufferSubData", ExactSpelling = true)]
            internal extern static void InvalidateBufferSubData(UInt32 buffer, IntPtr offset, IntPtr length);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInvalidateFramebuffer", ExactSpelling = true)]
            internal extern static void InvalidateFramebuffer(klukule.OpenGL.FramebufferTarget target, Int32 numAttachments, klukule.OpenGL.FramebufferAttachment[] attachments);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInvalidateNamedFramebufferData", ExactSpelling = true)]
            internal extern static void InvalidateNamedFramebufferData(UInt32 framebuffer, Int32 numAttachments, klukule.OpenGL.FramebufferAttachment[] attachments);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInvalidateSubFramebuffer", ExactSpelling = true)]
            internal extern static void InvalidateSubFramebuffer(klukule.OpenGL.FramebufferTarget target, Int32 numAttachments, klukule.OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInvalidateNamedFramebufferSubData", ExactSpelling = true)]
            internal extern static void InvalidateNamedFramebufferSubData(UInt32 framebuffer, Int32 numAttachments, klukule.OpenGL.FramebufferAttachment[] attachments, Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInvalidateTexImage", ExactSpelling = true)]
            internal extern static void InvalidateTexImage(UInt32 texture, Int32 level);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glInvalidateTexSubImage", ExactSpelling = true)]
            internal extern static void InvalidateTexSubImage(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsBuffer", ExactSpelling = true)]
            internal extern static Boolean IsBuffer(UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsEnabled", ExactSpelling = true)]
            internal extern static Boolean IsEnabled(klukule.OpenGL.EnableCap cap);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsEnabledi", ExactSpelling = true)]
            internal extern static Boolean IsEnabledi(klukule.OpenGL.EnableCap cap, UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsFramebuffer", ExactSpelling = true)]
            internal extern static Boolean IsFramebuffer(UInt32 framebuffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsProgram", ExactSpelling = true)]
            internal extern static Boolean IsProgram(UInt32 program);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsProgramPipeline", ExactSpelling = true)]
            internal extern static Boolean IsProgramPipeline(UInt32 pipeline);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsQuery", ExactSpelling = true)]
            internal extern static Boolean IsQuery(UInt32 id);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsRenderbuffer", ExactSpelling = true)]
            internal extern static Boolean IsRenderbuffer(UInt32 renderbuffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsSampler", ExactSpelling = true)]
            internal extern static Boolean IsSampler(UInt32 id);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsShader", ExactSpelling = true)]
            internal extern static Boolean IsShader(UInt32 shader);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsSync", ExactSpelling = true)]
            internal extern static Boolean IsSync(IntPtr sync);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsTexture", ExactSpelling = true)]
            internal extern static Boolean IsTexture(UInt32 texture);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsTransformFeedback", ExactSpelling = true)]
            internal extern static Boolean IsTransformFeedback(UInt32 id);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glIsVertexArray", ExactSpelling = true)]
            internal extern static Boolean IsVertexArray(UInt32 array);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLineWidth", ExactSpelling = true)]
            internal extern static void LineWidth(Single width);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLinkProgram", ExactSpelling = true)]
            internal extern static void LinkProgram(UInt32 program);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glLogicOp", ExactSpelling = true)]
            internal extern static void LogicOp(klukule.OpenGL.LogicOp opcode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapBuffer", ExactSpelling = true)]
            internal extern static IntPtr MapBuffer(klukule.OpenGL.BufferTarget target, klukule.OpenGL.BufferAccess access);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapNamedBuffer", ExactSpelling = true)]
            internal extern static IntPtr MapNamedBuffer(UInt32 buffer, klukule.OpenGL.BufferAccess access);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapBufferRange", ExactSpelling = true)]
            internal extern static IntPtr MapBufferRange(klukule.OpenGL.BufferTarget target, IntPtr offset, IntPtr length, klukule.OpenGL.BufferAccessMask access);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMapNamedBufferRange", ExactSpelling = true)]
            internal extern static IntPtr MapNamedBufferRange(UInt32 buffer, IntPtr offset, Int32 length, UInt32 access);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMemoryBarrier", ExactSpelling = true)]
            internal extern static void MemoryBarrier(UInt32 barriers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMemoryBarrierByRegion", ExactSpelling = true)]
            internal extern static void MemoryBarrierByRegion(UInt32 barriers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMinSampleShading", ExactSpelling = true)]
            internal extern static void MinSampleShading(Single value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawArrays", ExactSpelling = true)]
            internal extern static void MultiDrawArrays(klukule.OpenGL.BeginMode mode, Int32[] first, Int32[] count, Int32 drawcount);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawArraysIndirect", ExactSpelling = true)]
            internal extern static void MultiDrawArraysIndirect(klukule.OpenGL.BeginMode mode, IntPtr indirect, Int32 drawcount, Int32 stride);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawElements", ExactSpelling = true)]
            internal extern static void MultiDrawElements(klukule.OpenGL.BeginMode mode, Int32[] count, klukule.OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawElementsBaseVertex", ExactSpelling = true)]
            internal extern static void MultiDrawElementsBaseVertex(klukule.OpenGL.BeginMode mode, Int32[] count, klukule.OpenGL.DrawElementsType type, IntPtr indices, Int32 drawcount, Int32[] basevertex);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glMultiDrawElementsIndirect", ExactSpelling = true)]
            internal extern static void MultiDrawElementsIndirect(klukule.OpenGL.BeginMode mode, klukule.OpenGL.DrawElementsType type, IntPtr indirect, Int32 drawcount, Int32 stride);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glObjectLabel", ExactSpelling = true)]
            internal extern static void ObjectLabel(klukule.OpenGL.ObjectLabel identifier, UInt32 name, Int32 length, String label);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glObjectPtrLabel", ExactSpelling = true)]
            internal extern static void ObjectPtrLabel(IntPtr ptr, Int32 length, String label);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPatchParameteri", ExactSpelling = true)]
            internal extern static void PatchParameteri(Int32 pname, Int32 value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPatchParameterfv", ExactSpelling = true)]
            internal extern static void PatchParameterfv(Int32 pname, Single[] values);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelStoref", ExactSpelling = true)]
            internal extern static void PixelStoref(klukule.OpenGL.PixelStoreParameter pname, Single param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPixelStorei", ExactSpelling = true)]
            internal extern static void PixelStorei(klukule.OpenGL.PixelStoreParameter pname, Int32 param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterf", ExactSpelling = true)]
            internal extern static void PointParameterf(klukule.OpenGL.PointParameterName pname, Single param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameteri", ExactSpelling = true)]
            internal extern static void PointParameteri(klukule.OpenGL.PointParameterName pname, Int32 param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameterfv", ExactSpelling = true)]
            internal extern static void PointParameterfv(klukule.OpenGL.PointParameterName pname, Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointParameteriv", ExactSpelling = true)]
            internal extern static void PointParameteriv(klukule.OpenGL.PointParameterName pname, Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPointSize", ExactSpelling = true)]
            internal extern static void PointSize(Single size);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonMode", ExactSpelling = true)]
            internal extern static void PolygonMode(klukule.OpenGL.MaterialFace face, klukule.OpenGL.PolygonMode mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPolygonOffset", ExactSpelling = true)]
            internal extern static void PolygonOffset(Single factor, Single units);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glPrimitiveRestartIndex", ExactSpelling = true)]
            internal extern static void PrimitiveRestartIndex(UInt32 index);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramBinary", ExactSpelling = true)]
            internal extern static void ProgramBinary(UInt32 program, Int32 binaryFormat, IntPtr binary, Int32 length);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramParameteri", ExactSpelling = true)]
            internal extern static void ProgramParameteri(UInt32 program, klukule.OpenGL.Version32 pname, Int32 value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform1f", ExactSpelling = true)]
            internal extern static void ProgramUniform1f(UInt32 program, Int32 location, Single v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform2f", ExactSpelling = true)]
            internal extern static void ProgramUniform2f(UInt32 program, Int32 location, Single v0, Single v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform3f", ExactSpelling = true)]
            internal extern static void ProgramUniform3f(UInt32 program, Int32 location, Single v0, Single v1, Single v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform4f", ExactSpelling = true)]
            internal extern static void ProgramUniform4f(UInt32 program, Int32 location, Single v0, Single v1, Single v2, Single v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform1i", ExactSpelling = true)]
            internal extern static void ProgramUniform1i(UInt32 program, Int32 location, Int32 v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform2i", ExactSpelling = true)]
            internal extern static void ProgramUniform2i(UInt32 program, Int32 location, Int32 v0, Int32 v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform3i", ExactSpelling = true)]
            internal extern static void ProgramUniform3i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform4i", ExactSpelling = true)]
            internal extern static void ProgramUniform4i(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform1ui", ExactSpelling = true)]
            internal extern static void ProgramUniform1ui(UInt32 program, Int32 location, UInt32 v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform2ui", ExactSpelling = true)]
            internal extern static void ProgramUniform2ui(UInt32 program, Int32 location, Int32 v0, UInt32 v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform3ui", ExactSpelling = true)]
            internal extern static void ProgramUniform3ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, UInt32 v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform4ui", ExactSpelling = true)]
            internal extern static void ProgramUniform4ui(UInt32 program, Int32 location, Int32 v0, Int32 v1, Int32 v2, UInt32 v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform1fv", ExactSpelling = true)]
            internal extern static void ProgramUniform1fv(UInt32 program, Int32 location, Int32 count, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform2fv", ExactSpelling = true)]
            internal extern static void ProgramUniform2fv(UInt32 program, Int32 location, Int32 count, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform3fv", ExactSpelling = true)]
            internal extern static void ProgramUniform3fv(UInt32 program, Int32 location, Int32 count, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform4fv", ExactSpelling = true)]
            internal extern static void ProgramUniform4fv(UInt32 program, Int32 location, Int32 count, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform1iv", ExactSpelling = true)]
            internal extern static void ProgramUniform1iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform2iv", ExactSpelling = true)]
            internal extern static void ProgramUniform2iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform3iv", ExactSpelling = true)]
            internal extern static void ProgramUniform3iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform4iv", ExactSpelling = true)]
            internal extern static void ProgramUniform4iv(UInt32 program, Int32 location, Int32 count, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform1uiv", ExactSpelling = true)]
            internal extern static void ProgramUniform1uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform2uiv", ExactSpelling = true)]
            internal extern static void ProgramUniform2uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform3uiv", ExactSpelling = true)]
            internal extern static void ProgramUniform3uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniform4uiv", ExactSpelling = true)]
            internal extern static void ProgramUniform4uiv(UInt32 program, Int32 location, Int32 count, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2x3fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix2x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3x2fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix3x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix2x4fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix2x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4x2fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix4x2fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix3x4fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix3x4fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProgramUniformMatrix4x3fv", ExactSpelling = true)]
            internal extern static void ProgramUniformMatrix4x3fv(UInt32 program, Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glProvokingVertex", ExactSpelling = true)]
            internal extern static void ProvokingVertex(klukule.OpenGL.ProvokingVertexMode provokeMode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glQueryCounter", ExactSpelling = true)]
            internal extern static void QueryCounter(UInt32 id, Int32 target);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReadBuffer", ExactSpelling = true)]
            internal extern static void ReadBuffer(klukule.OpenGL.ReadBufferMode mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedFramebufferReadBuffer", ExactSpelling = true)]
            internal extern static void NamedFramebufferReadBuffer(UInt32 framebuffer, klukule.OpenGL.BeginMode mode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReadPixels", ExactSpelling = true)]
            internal extern static void ReadPixels(Int32 x, Int32 y, Int32 width, Int32 height, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, Int32[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glReadnPixels", ExactSpelling = true)]
            internal extern static void ReadnPixels(Int32 x, Int32 y, Int32 width, Int32 height, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, Int32 bufSize, Int32[] data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRenderbufferStorage", ExactSpelling = true)]
            internal extern static void RenderbufferStorage(klukule.OpenGL.RenderbufferTarget target, klukule.OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedRenderbufferStorage", ExactSpelling = true)]
            internal extern static void NamedRenderbufferStorage(UInt32 renderbuffer, klukule.OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glRenderbufferStorageMultisample", ExactSpelling = true)]
            internal extern static void RenderbufferStorageMultisample(klukule.OpenGL.RenderbufferTarget target, Int32 samples, klukule.OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glNamedRenderbufferStorageMultisample", ExactSpelling = true)]
            internal extern static void NamedRenderbufferStorageMultisample(UInt32 renderbuffer, Int32 samples, klukule.OpenGL.RenderbufferStorage internalFormat, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSampleCoverage", ExactSpelling = true)]
            internal extern static void SampleCoverage(Single value, Boolean invert);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSampleMaski", ExactSpelling = true)]
            internal extern static void SampleMaski(UInt32 maskNumber, UInt32 mask);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSamplerParameterf", ExactSpelling = true)]
            internal extern static void SamplerParameterf(UInt32 sampler, Int32 pname, Single param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSamplerParameteri", ExactSpelling = true)]
            internal extern static void SamplerParameteri(UInt32 sampler, Int32 pname, Int32 param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSamplerParameterfv", ExactSpelling = true)]
            internal extern static void SamplerParameterfv(UInt32 sampler, Int32 pname, Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSamplerParameteriv", ExactSpelling = true)]
            internal extern static void SamplerParameteriv(UInt32 sampler, Int32 pname, Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSamplerParameterIiv", ExactSpelling = true)]
            internal extern static void SamplerParameterIiv(UInt32 sampler, klukule.OpenGL.TextureParameterName pname, Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glSamplerParameterIuiv", ExactSpelling = true)]
            internal extern static void SamplerParameterIuiv(UInt32 sampler, klukule.OpenGL.TextureParameterName pname, UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScissor", ExactSpelling = true)]
            internal extern static void Scissor(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScissorArrayv", ExactSpelling = true)]
            internal extern static void ScissorArrayv(UInt32 first, Int32 count, Int32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScissorIndexed", ExactSpelling = true)]
            internal extern static void ScissorIndexed(UInt32 index, Int32 left, Int32 bottom, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glScissorIndexedv", ExactSpelling = true)]
            internal extern static void ScissorIndexedv(UInt32 index, Int32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderBinary", ExactSpelling = true)]
            internal extern static void ShaderBinary(Int32 count, UInt32[] shaders, Int32 binaryFormat, IntPtr binary, Int32 length);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderSource", ExactSpelling = true)]
            internal extern static void ShaderSource(UInt32 shader, Int32 count, String[] @string, Int32[] length);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glShaderStorageBlockBinding", ExactSpelling = true)]
            internal extern static void ShaderStorageBlockBinding(UInt32 program, UInt32 storageBlockIndex, UInt32 storageBlockBinding);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilFunc", ExactSpelling = true)]
            internal extern static void StencilFunc(klukule.OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilFuncSeparate", ExactSpelling = true)]
            internal extern static void StencilFuncSeparate(klukule.OpenGL.StencilFace face, klukule.OpenGL.StencilFunction func, Int32 @ref, UInt32 mask);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilMask", ExactSpelling = true)]
            internal extern static void StencilMask(UInt32 mask);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilMaskSeparate", ExactSpelling = true)]
            internal extern static void StencilMaskSeparate(klukule.OpenGL.StencilFace face, UInt32 mask);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilOp", ExactSpelling = true)]
            internal extern static void StencilOp(klukule.OpenGL.StencilOp sfail, klukule.OpenGL.StencilOp dpfail, klukule.OpenGL.StencilOp dppass);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glStencilOpSeparate", ExactSpelling = true)]
            internal extern static void StencilOpSeparate(klukule.OpenGL.StencilFace face, klukule.OpenGL.StencilOp sfail, klukule.OpenGL.StencilOp dpfail, klukule.OpenGL.StencilOp dppass);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexBuffer", ExactSpelling = true)]
            internal extern static void TexBuffer(klukule.OpenGL.TextureBufferTarget target, klukule.OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureBuffer", ExactSpelling = true)]
            internal extern static void TextureBuffer(UInt32 texture, klukule.OpenGL.SizedInternalFormat internalFormat, UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexBufferRange", ExactSpelling = true)]
            internal extern static void TexBufferRange(klukule.OpenGL.BufferTarget target, klukule.OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, IntPtr size);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureBufferRange", ExactSpelling = true)]
            internal extern static void TextureBufferRange(UInt32 texture, klukule.OpenGL.SizedInternalFormat internalFormat, UInt32 buffer, IntPtr offset, Int32 size);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage1D", ExactSpelling = true)]
            internal extern static void TexImage1D(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 border, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage2D", ExactSpelling = true)]
            internal extern static void TexImage2D(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 border, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage2DMultisample", ExactSpelling = true)]
            internal extern static void TexImage2DMultisample(klukule.OpenGL.TextureTargetMultisample target, Int32 samples, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage3D", ExactSpelling = true)]
            internal extern static void TexImage3D(klukule.OpenGL.TextureTarget target, Int32 level, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Int32 border, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr data);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexImage3DMultisample", ExactSpelling = true)]
            internal extern static void TexImage3DMultisample(klukule.OpenGL.TextureTargetMultisample target, Int32 samples, klukule.OpenGL.PixelInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterf", ExactSpelling = true)]
            internal extern static void TexParameterf(klukule.OpenGL.TextureTarget target, klukule.OpenGL.TextureParameterName pname, Single param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameteri", ExactSpelling = true)]
            internal extern static void TexParameteri(klukule.OpenGL.TextureTarget target, klukule.OpenGL.TextureParameterName pname, Int32 param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureParameterf", ExactSpelling = true)]
            internal extern static void TextureParameterf(UInt32 texture, klukule.OpenGL.TextureParameter pname, Single param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureParameteri", ExactSpelling = true)]
            internal extern static void TextureParameteri(UInt32 texture, klukule.OpenGL.TextureParameter pname, Int32 param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterfv", ExactSpelling = true)]
            internal extern static void TexParameterfv(klukule.OpenGL.TextureTarget target, klukule.OpenGL.TextureParameterName pname, Single[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameteriv", ExactSpelling = true)]
            internal extern static void TexParameteriv(klukule.OpenGL.TextureTarget target, klukule.OpenGL.TextureParameterName pname, Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterIiv", ExactSpelling = true)]
            internal extern static void TexParameterIiv(klukule.OpenGL.TextureTarget target, klukule.OpenGL.TextureParameterName pname, Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexParameterIuiv", ExactSpelling = true)]
            internal extern static void TexParameterIuiv(klukule.OpenGL.TextureTarget target, klukule.OpenGL.TextureParameterName pname, UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureParameterfv", ExactSpelling = true)]
            internal extern static void TextureParameterfv(UInt32 texture, klukule.OpenGL.TextureParameter pname, Single[] paramtexture);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureParameteriv", ExactSpelling = true)]
            internal extern static void TextureParameteriv(UInt32 texture, klukule.OpenGL.TextureParameter pname, Int32[] param);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureParameterIiv", ExactSpelling = true)]
            internal extern static void TextureParameterIiv(UInt32 texture, klukule.OpenGL.TextureParameter pname, Int32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureParameterIuiv", ExactSpelling = true)]
            internal extern static void TextureParameterIuiv(UInt32 texture, klukule.OpenGL.TextureParameter pname, UInt32[] @params);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexStorage1D", ExactSpelling = true)]
            internal extern static void TexStorage1D(klukule.OpenGL.TextureTarget target, Int32 levels, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureStorage1D", ExactSpelling = true)]
            internal extern static void TextureStorage1D(UInt32 texture, Int32 levels, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexStorage2D", ExactSpelling = true)]
            internal extern static void TexStorage2D(klukule.OpenGL.TextureTarget target, Int32 levels, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureStorage2D", ExactSpelling = true)]
            internal extern static void TextureStorage2D(UInt32 texture, Int32 levels, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexStorage2DMultisample", ExactSpelling = true)]
            internal extern static void TexStorage2DMultisample(klukule.OpenGL.TextureTarget target, Int32 samples, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureStorage2DMultisample", ExactSpelling = true)]
            internal extern static void TextureStorage2DMultisample(UInt32 texture, Int32 samples, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Boolean fixedsamplelocations);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexStorage3D", ExactSpelling = true)]
            internal extern static void TexStorage3D(klukule.OpenGL.TextureTarget target, Int32 levels, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureStorage3D", ExactSpelling = true)]
            internal extern static void TextureStorage3D(UInt32 texture, Int32 levels, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexStorage3DMultisample", ExactSpelling = true)]
            internal extern static void TexStorage3DMultisample(klukule.OpenGL.TextureTarget target, Int32 samples, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureStorage3DMultisample", ExactSpelling = true)]
            internal extern static void TextureStorage3DMultisample(UInt32 texture, Int32 samples, klukule.OpenGL.SizedInternalFormat internalFormat, Int32 width, Int32 height, Int32 depth, Boolean fixedsamplelocations);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage1D", ExactSpelling = true)]
            internal extern static void TexSubImage1D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 width, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureSubImage1D", ExactSpelling = true)]
            internal extern static void TextureSubImage1D(UInt32 texture, Int32 level, Int32 xoffset, Int32 width, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage2D", ExactSpelling = true)]
            internal extern static void TexSubImage2D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureSubImage2D", ExactSpelling = true)]
            internal extern static void TextureSubImage2D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 width, Int32 height, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTexSubImage3D", ExactSpelling = true)]
            internal extern static void TexSubImage3D(klukule.OpenGL.TextureTarget target, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureSubImage3D", ExactSpelling = true)]
            internal extern static void TextureSubImage3D(UInt32 texture, Int32 level, Int32 xoffset, Int32 yoffset, Int32 zoffset, Int32 width, Int32 height, Int32 depth, klukule.OpenGL.PixelFormat format, klukule.OpenGL.PixelType type, IntPtr pixels);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureBarrier", ExactSpelling = true)]
            internal extern static void TextureBarrier();
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTextureView", ExactSpelling = true)]
            internal extern static void TextureView(UInt32 texture, klukule.OpenGL.TextureTarget target, UInt32 origtexture, klukule.OpenGL.PixelInternalFormat internalFormat, UInt32 minlevel, UInt32 numlevels, UInt32 minlayer, UInt32 numlayers);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTransformFeedbackBufferBase", ExactSpelling = true)]
            internal extern static void TransformFeedbackBufferBase(UInt32 xfb, UInt32 index, UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTransformFeedbackBufferRange", ExactSpelling = true)]
            internal extern static void TransformFeedbackBufferRange(UInt32 xfb, UInt32 index, UInt32 buffer, IntPtr offset, Int32 size);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glTransformFeedbackVaryings", ExactSpelling = true)]
            internal extern static void TransformFeedbackVaryings(UInt32 program, Int32 count, String[] varyings, klukule.OpenGL.TransformFeedbackMode bufferMode);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1f", ExactSpelling = true)]
            internal extern static void Uniform1f(Int32 location, Single v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2f", ExactSpelling = true)]
            internal extern static void Uniform2f(Int32 location, Single v0, Single v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3f", ExactSpelling = true)]
            internal extern static void Uniform3f(Int32 location, Single v0, Single v1, Single v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4f", ExactSpelling = true)]
            internal extern static void Uniform4f(Int32 location, Single v0, Single v1, Single v2, Single v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1i", ExactSpelling = true)]
            internal extern static void Uniform1i(Int32 location, Int32 v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2i", ExactSpelling = true)]
            internal extern static void Uniform2i(Int32 location, Int32 v0, Int32 v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3i", ExactSpelling = true)]
            internal extern static void Uniform3i(Int32 location, Int32 v0, Int32 v1, Int32 v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4i", ExactSpelling = true)]
            internal extern static void Uniform4i(Int32 location, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1ui", ExactSpelling = true)]
            internal extern static void Uniform1ui(Int32 location, UInt32 v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2ui", ExactSpelling = true)]
            internal extern static void Uniform2ui(Int32 location, UInt32 v0, UInt32 v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3ui", ExactSpelling = true)]
            internal extern static void Uniform3ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4ui", ExactSpelling = true)]
            internal extern static void Uniform4ui(Int32 location, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1fv", ExactSpelling = true)]
            internal extern static void Uniform1fv(Int32 location, Int32 count, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2fv", ExactSpelling = true)]
            internal extern static void Uniform2fv(Int32 location, Int32 count, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3fv", ExactSpelling = true)]
            internal extern static void Uniform3fv(Int32 location, Int32 count, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4fv", ExactSpelling = true)]
            internal extern static void Uniform4fv(Int32 location, Int32 count, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1iv", ExactSpelling = true)]
            internal extern static void Uniform1iv(Int32 location, Int32 count, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2iv", ExactSpelling = true)]
            internal extern static void Uniform2iv(Int32 location, Int32 count, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3iv", ExactSpelling = true)]
            internal extern static void Uniform3iv(Int32 location, Int32 count, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4iv", ExactSpelling = true)]
            internal extern static void Uniform4iv(Int32 location, Int32 count, Int32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform1uiv", ExactSpelling = true)]
            internal extern static void Uniform1uiv(Int32 location, Int32 count, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform2uiv", ExactSpelling = true)]
            internal extern static void Uniform2uiv(Int32 location, Int32 count, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform3uiv", ExactSpelling = true)]
            internal extern static void Uniform3uiv(Int32 location, Int32 count, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniform4uiv", ExactSpelling = true)]
            internal extern static void Uniform4uiv(Int32 location, Int32 count, UInt32[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2fv", ExactSpelling = true)]
            internal extern static void UniformMatrix2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3fv", ExactSpelling = true)]
            internal extern static void UniformMatrix3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4fv", ExactSpelling = true)]
            internal extern static void UniformMatrix4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2x3fv", ExactSpelling = true)]
            internal extern static void UniformMatrix2x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3x2fv", ExactSpelling = true)]
            internal extern static void UniformMatrix3x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix2x4fv", ExactSpelling = true)]
            internal extern static void UniformMatrix2x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4x2fv", ExactSpelling = true)]
            internal extern static void UniformMatrix4x2fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix3x4fv", ExactSpelling = true)]
            internal extern static void UniformMatrix3x4fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformMatrix4x3fv", ExactSpelling = true)]
            internal extern static void UniformMatrix4x3fv(Int32 location, Int32 count, Boolean transpose, Single[] value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformBlockBinding", ExactSpelling = true)]
            internal extern static void UniformBlockBinding(UInt32 program, UInt32 uniformBlockIndex, UInt32 uniformBlockBinding);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUniformSubroutinesuiv", ExactSpelling = true)]
            internal extern static void UniformSubroutinesuiv(klukule.OpenGL.ShaderType shadertype, Int32 count, UInt32[] indices);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUnmapBuffer", ExactSpelling = true)]
            internal extern static Boolean UnmapBuffer(klukule.OpenGL.BufferTarget target);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUnmapNamedBuffer", ExactSpelling = true)]
            internal extern static Boolean UnmapNamedBuffer(UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUseProgram", ExactSpelling = true)]
            internal extern static void UseProgram(UInt32 program);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glUseProgramStages", ExactSpelling = true)]
            internal extern static void UseProgramStages(UInt32 pipeline, UInt32 stages, UInt32 program);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glValidateProgram", ExactSpelling = true)]
            internal extern static void ValidateProgram(UInt32 program);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glValidateProgramPipeline", ExactSpelling = true)]
            internal extern static void ValidateProgramPipeline(UInt32 pipeline);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayElementBuffer", ExactSpelling = true)]
            internal extern static void VertexArrayElementBuffer(UInt32 vaobj, UInt32 buffer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1f", ExactSpelling = true)]
            internal extern static void VertexAttrib1f(UInt32 index, Single v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1s", ExactSpelling = true)]
            internal extern static void VertexAttrib1s(UInt32 index, Int16 v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1d", ExactSpelling = true)]
            internal extern static void VertexAttrib1d(UInt32 index, Double v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI1i", ExactSpelling = true)]
            internal extern static void VertexAttribI1i(UInt32 index, Int32 v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI1ui", ExactSpelling = true)]
            internal extern static void VertexAttribI1ui(UInt32 index, UInt32 v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2f", ExactSpelling = true)]
            internal extern static void VertexAttrib2f(UInt32 index, Single v0, Single v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2s", ExactSpelling = true)]
            internal extern static void VertexAttrib2s(UInt32 index, Int16 v0, Int16 v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2d", ExactSpelling = true)]
            internal extern static void VertexAttrib2d(UInt32 index, Double v0, Double v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI2i", ExactSpelling = true)]
            internal extern static void VertexAttribI2i(UInt32 index, Int32 v0, Int32 v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI2ui", ExactSpelling = true)]
            internal extern static void VertexAttribI2ui(UInt32 index, UInt32 v0, UInt32 v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3f", ExactSpelling = true)]
            internal extern static void VertexAttrib3f(UInt32 index, Single v0, Single v1, Single v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3s", ExactSpelling = true)]
            internal extern static void VertexAttrib3s(UInt32 index, Int16 v0, Int16 v1, Int16 v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3d", ExactSpelling = true)]
            internal extern static void VertexAttrib3d(UInt32 index, Double v0, Double v1, Double v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI3i", ExactSpelling = true)]
            internal extern static void VertexAttribI3i(UInt32 index, Int32 v0, Int32 v1, Int32 v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI3ui", ExactSpelling = true)]
            internal extern static void VertexAttribI3ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4f", ExactSpelling = true)]
            internal extern static void VertexAttrib4f(UInt32 index, Single v0, Single v1, Single v2, Single v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4s", ExactSpelling = true)]
            internal extern static void VertexAttrib4s(UInt32 index, Int16 v0, Int16 v1, Int16 v2, Int16 v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4d", ExactSpelling = true)]
            internal extern static void VertexAttrib4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nub", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nub(UInt32 index, Byte v0, Byte v1, Byte v2, Byte v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4i", ExactSpelling = true)]
            internal extern static void VertexAttribI4i(UInt32 index, Int32 v0, Int32 v1, Int32 v2, Int32 v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4ui", ExactSpelling = true)]
            internal extern static void VertexAttribI4ui(UInt32 index, UInt32 v0, UInt32 v1, UInt32 v2, UInt32 v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribL1d", ExactSpelling = true)]
            internal extern static void VertexAttribL1d(UInt32 index, Double v0);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribL2d", ExactSpelling = true)]
            internal extern static void VertexAttribL2d(UInt32 index, Double v0, Double v1);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribL3d", ExactSpelling = true)]
            internal extern static void VertexAttribL3d(UInt32 index, Double v0, Double v1, Double v2);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribL4d", ExactSpelling = true)]
            internal extern static void VertexAttribL4d(UInt32 index, Double v0, Double v1, Double v2, Double v3);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1fv", ExactSpelling = true)]
            internal extern static void VertexAttrib1fv(UInt32 index, Single[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1sv", ExactSpelling = true)]
            internal extern static void VertexAttrib1sv(UInt32 index, Int16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib1dv", ExactSpelling = true)]
            internal extern static void VertexAttrib1dv(UInt32 index, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI1iv", ExactSpelling = true)]
            internal extern static void VertexAttribI1iv(UInt32 index, Int32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI1uiv", ExactSpelling = true)]
            internal extern static void VertexAttribI1uiv(UInt32 index, UInt32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2fv", ExactSpelling = true)]
            internal extern static void VertexAttrib2fv(UInt32 index, Single[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2sv", ExactSpelling = true)]
            internal extern static void VertexAttrib2sv(UInt32 index, Int16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib2dv", ExactSpelling = true)]
            internal extern static void VertexAttrib2dv(UInt32 index, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI2iv", ExactSpelling = true)]
            internal extern static void VertexAttribI2iv(UInt32 index, Int32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI2uiv", ExactSpelling = true)]
            internal extern static void VertexAttribI2uiv(UInt32 index, UInt32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3fv", ExactSpelling = true)]
            internal extern static void VertexAttrib3fv(UInt32 index, Single[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3sv", ExactSpelling = true)]
            internal extern static void VertexAttrib3sv(UInt32 index, Int16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib3dv", ExactSpelling = true)]
            internal extern static void VertexAttrib3dv(UInt32 index, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI3iv", ExactSpelling = true)]
            internal extern static void VertexAttribI3iv(UInt32 index, Int32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI3uiv", ExactSpelling = true)]
            internal extern static void VertexAttribI3uiv(UInt32 index, UInt32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4fv", ExactSpelling = true)]
            internal extern static void VertexAttrib4fv(UInt32 index, Single[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4sv", ExactSpelling = true)]
            internal extern static void VertexAttrib4sv(UInt32 index, Int16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4dv", ExactSpelling = true)]
            internal extern static void VertexAttrib4dv(UInt32 index, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4iv", ExactSpelling = true)]
            internal extern static void VertexAttrib4iv(UInt32 index, Int32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4bv", ExactSpelling = true)]
            internal extern static void VertexAttrib4bv(UInt32 index, SByte[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4ubv", ExactSpelling = true)]
            internal extern static void VertexAttrib4ubv(UInt32 index, Byte[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4usv", ExactSpelling = true)]
            internal extern static void VertexAttrib4usv(UInt32 index, UInt16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4uiv", ExactSpelling = true)]
            internal extern static void VertexAttrib4uiv(UInt32 index, UInt32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nbv", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nbv(UInt32 index, SByte[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nsv", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nsv(UInt32 index, Int16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Niv", ExactSpelling = true)]
            internal extern static void VertexAttrib4Niv(UInt32 index, Int32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nubv", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nubv(UInt32 index, Byte[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nusv", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nusv(UInt32 index, UInt16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttrib4Nuiv", ExactSpelling = true)]
            internal extern static void VertexAttrib4Nuiv(UInt32 index, UInt32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4bv", ExactSpelling = true)]
            internal extern static void VertexAttribI4bv(UInt32 index, SByte[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4ubv", ExactSpelling = true)]
            internal extern static void VertexAttribI4ubv(UInt32 index, Byte[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4sv", ExactSpelling = true)]
            internal extern static void VertexAttribI4sv(UInt32 index, Int16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4usv", ExactSpelling = true)]
            internal extern static void VertexAttribI4usv(UInt32 index, UInt16[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4iv", ExactSpelling = true)]
            internal extern static void VertexAttribI4iv(UInt32 index, Int32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribI4uiv", ExactSpelling = true)]
            internal extern static void VertexAttribI4uiv(UInt32 index, UInt32[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribL1dv", ExactSpelling = true)]
            internal extern static void VertexAttribL1dv(UInt32 index, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribL2dv", ExactSpelling = true)]
            internal extern static void VertexAttribL2dv(UInt32 index, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribL3dv", ExactSpelling = true)]
            internal extern static void VertexAttribL3dv(UInt32 index, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribL4dv", ExactSpelling = true)]
            internal extern static void VertexAttribL4dv(UInt32 index, Double[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribP1ui", ExactSpelling = true)]
            internal extern static void VertexAttribP1ui(UInt32 index, klukule.OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribP2ui", ExactSpelling = true)]
            internal extern static void VertexAttribP2ui(UInt32 index, klukule.OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribP3ui", ExactSpelling = true)]
            internal extern static void VertexAttribP3ui(UInt32 index, klukule.OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribP4ui", ExactSpelling = true)]
            internal extern static void VertexAttribP4ui(UInt32 index, klukule.OpenGL.VertexAttribPType type, Boolean normalized, UInt32 value);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribBinding", ExactSpelling = true)]
            internal extern static void VertexAttribBinding(UInt32 attribindex, UInt32 bindingindex);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayAttribBinding", ExactSpelling = true)]
            internal extern static void VertexArrayAttribBinding(UInt32 vaobj, UInt32 attribindex, UInt32 bindingindex);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribDivisor", ExactSpelling = true)]
            internal extern static void VertexAttribDivisor(UInt32 index, UInt32 divisor);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribFormat", ExactSpelling = true)]
            internal extern static void VertexAttribFormat(UInt32 attribindex, Int32 size, klukule.OpenGL.VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribIFormat", ExactSpelling = true)]
            internal extern static void VertexAttribIFormat(UInt32 attribindex, Int32 size, klukule.OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribLFormat", ExactSpelling = true)]
            internal extern static void VertexAttribLFormat(UInt32 attribindex, Int32 size, klukule.OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayAttribFormat", ExactSpelling = true)]
            internal extern static void VertexArrayAttribFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, klukule.OpenGL.VertexAttribFormat type, Boolean normalized, UInt32 relativeoffset);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayAttribIFormat", ExactSpelling = true)]
            internal extern static void VertexArrayAttribIFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, klukule.OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayAttribLFormat", ExactSpelling = true)]
            internal extern static void VertexArrayAttribLFormat(UInt32 vaobj, UInt32 attribindex, Int32 size, klukule.OpenGL.VertexAttribFormat type, UInt32 relativeoffset);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribPointer", ExactSpelling = true)]
            internal extern static void VertexAttribPointer(UInt32 index, Int32 size, klukule.OpenGL.VertexAttribPointerType type, Boolean normalized, Int32 stride, IntPtr pointer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribIPointer", ExactSpelling = true)]
            internal extern static void VertexAttribIPointer(UInt32 index, Int32 size, klukule.OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexAttribLPointer", ExactSpelling = true)]
            internal extern static void VertexAttribLPointer(UInt32 index, Int32 size, klukule.OpenGL.VertexAttribPointerType type, Int32 stride, IntPtr pointer);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexBindingDivisor", ExactSpelling = true)]
            internal extern static void VertexBindingDivisor(UInt32 bindingindex, UInt32 divisor);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glVertexArrayBindingDivisor", ExactSpelling = true)]
            internal extern static void VertexArrayBindingDivisor(UInt32 vaobj, UInt32 bindingindex, UInt32 divisor);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glViewport", ExactSpelling = true)]
            internal extern static void Viewport(Int32 x, Int32 y, Int32 width, Int32 height);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glViewportArrayv", ExactSpelling = true)]
            internal extern static void ViewportArrayv(UInt32 first, Int32 count, Single[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glViewportIndexedf", ExactSpelling = true)]
            internal extern static void ViewportIndexedf(UInt32 index, Single x, Single y, Single w, Single h);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glViewportIndexedfv", ExactSpelling = true)]
            internal extern static void ViewportIndexedfv(UInt32 index, Single[] v);
            [System.Runtime.InteropServices.DllImport(Gl.Library, EntryPoint = "glWaitSync", ExactSpelling = true)]
            internal extern static void WaitSync(IntPtr sync, UInt32 flags, UInt64 timeout);
        }
    }
}
