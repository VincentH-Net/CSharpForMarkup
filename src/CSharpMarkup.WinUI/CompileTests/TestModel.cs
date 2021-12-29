#if DEBUG
namespace CompileTests
{
    public partial class TestViewModel
    {
        public string Title { get; set; }
        public bool Right { get; set; }
        public bool IsOk { get; set; }
        public string Avatar { get; set; }

        public int Columns { get; set; }
    }
}
#endif