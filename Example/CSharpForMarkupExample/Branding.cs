namespace CSharpForMarkupExample
{
    public enum Colors : uint
    {
        BgBlue1 = 0xff0f344au,
        BgBlue2 = 0xff1c588bu,
        BgGray2 = 0xfff5f6f7u,
        BgGray3 = 0xffe9eef8u,

        Gray1 = 0xff737171u,
        Gray2 = 0xffeaeae9u,
        White = 0xffffffffu,
        Green = 0xff92bb29u,
        Transparent = 0x00000000u,

        Blue2 = 0xff33a6deu,
        Red = 0xffe34f16u,

        ColorValuePrimary = 0xff2674b8u, // Blue 2. Primary is used for dark backgrounds in non-accented system elements, e.g. navigation bar, title bar, selected item
        ColorValueAccent = 0xffec681cu,  // Orange 1. Accent is used for dark backgrounds in accented system elements, e.g. button, accented status, text entry underline (on android)
    }

    public enum FontSizes
    {
        _13 = 13,
        _14 = 14,
        _15 = 15,
        _24 = 24,
    }
}
