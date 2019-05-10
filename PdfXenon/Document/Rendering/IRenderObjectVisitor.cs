﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PdfXenon.Standard
{
    public interface IRenderObjectVisitor
    {
        void Visit(Renderer obj);
        void Visit(RenderGraphicsState obj);
        void Visit(RenderObject obj);
    }
}