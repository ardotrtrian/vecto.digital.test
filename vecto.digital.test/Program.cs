
var ImageEffect_1 = new Plugin()
{
    Blur = new() { ToBlur = true, Pixels = 2 },
    Resize = new() { ToResize = true, Pixels = 100 },
};

var ImageEffect_2 = new Plugin()
{
    Resize = new() { ToResize = true, Pixels = 100 },
};

var ImageEffect_3 = new Plugin()
{
    Blur = new() { ToBlur = true, Pixels = 5 },
    Resize = new() { ToResize = true, Pixels = 150 },
    Grayscale = new() { ToConvert = true }
};

Console.Write("Image#1:");
Editor.Apply(ImageEffect_1);

Console.Write("Image#2:");
Editor.Apply(ImageEffect_2);

Console.Write("Image#3:");
Editor.Apply(ImageEffect_3);