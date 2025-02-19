using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Music
{
    public static class LyricMusic
    {
        public static List<(TimeSpan, string)> ThangTuLaLoiNoiDoiCuaEm()
        {
            return new List<(TimeSpan, string)>
            {
                (TimeSpan.FromSeconds(25), "🎤🎤🎤"),
                (TimeSpan.FromSeconds(27), "🎤🎤"),
                (TimeSpan.FromSeconds(29), "🎤"),
                (TimeSpan.FromSeconds(30), " "),

                (TimeSpan.FromSeconds(31), "Mùa xuân có em " +
                "\n\t       ...như chưa bắt đầu"),
                (TimeSpan.FromSeconds(38), "Và cơn gió như khẽ mơn man" +
                "\n\t       ... lay từng nhành hoa rơi"),
                (TimeSpan.FromSeconds(45), "Em đã bước tới " +
                "\n\t       ...như em đã từng"),
                (TimeSpan.FromSeconds(52), "Chạy trốn với anh" +
                "\n\t       ... trên cánh đồng xanh"),
                (TimeSpan.FromSeconds(58), "Khúc nhạc hòa cùng nắng chiều dịu dàng " +
                "\n         ... để mình gần lại mãi"),
                (TimeSpan.FromSeconds(65), "Nói lời thì thầm những điều thật thà" +
                "\n         ... đã giữ trong tim mình"),
                (TimeSpan.FromSeconds(72), "Những chặng đường dài " +
                "\n\t       ... ngỡ mình mệt nhoài"),
                (TimeSpan.FromSeconds(76), "Đã một lần gục ngã"),
                (TimeSpan.FromSeconds(80), "Tháng tư có em ở đây " +
                "\n\t       ... nhìn tôi mỉm cười"),
                (TimeSpan.FromSeconds(86), "Những cánh hoa phai tàn thật nhanh"),
                (TimeSpan.FromSeconds(89), "Em có bay xa em có đi xa mãi"),
                (TimeSpan.FromSeconds(93), "Tháng tư đôi khi thật mong manh"),
                (TimeSpan.FromSeconds(97), "Để mình nói ra những câu chân thật"),
                (TimeSpan.FromSeconds(101), "Giá như tôi một lần tin em"),
                (TimeSpan.FromSeconds(104), "Cô gái tôi thương nay hóa theo mây gió"),
                (TimeSpan.FromSeconds(109), "Để lại tháng tư ở đó..."),
            };
        }
    }
}
