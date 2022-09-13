using MovieApp.Data;

namespace MovieApp
{
    public static class DataSeeder
    {
        public static void Seed(this IHost host)
        {
            using var scope = host.Services.CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<MovieDataContext>();
            context.Database.EnsureCreated();
            AddMovies(context);
        }

        private static void AddMovies(MovieDataContext context)
        {
            var movie = context.Movies.FirstOrDefault();
            if (movie != null) return;

            context.Movies.Add(new Movie
            {
                Title = "The Shawshank Redemption",
                Year = 1994,
                Summary = "Phim xoay quanh cuộc đời của phó chủ tịch nhà băng Portland – Andy Dufresne (Tim Robbins). Năm 1947, vợ và nhân tình của vợ đột nhiên bị giết và mọi người ngờ rằng Andy đã giết họ vì ghen tuông. Mặc dù anh một mực kêu oan, nhưng tất cả mọi bằng chứng đều chống lại anh. Bản án được thi hành và Andy bị bắt giam tại nhà tù Shawshank nổi tiếng ở Maine.",
                Actors = new List<Actor>
                {
                    new Actor { Fullname = "Morgan Freeman"},
                    new Actor { Fullname = "Tim Robbins"}
                }
            });

            context.Movies.Add(new Movie
            {
                Title = "The Godfather",
                Year = 1972,
                Summary = "Bố già xoay quanh cuộc sống trong vòng 10 năm một gia đình tài phiệt mafia gốc Ý, nhà Corleone. Diễn biến của phim xoay quanh cuộc trả thù đẫm máu của Michael – người con trai cả của ông trùm Vito Corleone trong cuộc chiến báo thù cho cha sau khi ông trùm Vito bị ám sát.",
                Actors = new List<Actor>
                {
                    new Actor { Fullname = "Marlon Brando" },
                    new Actor { Fullname = "Al Pacino " },
                }
            });

            context.Movies.Add(new Movie
            {
                Title = "The Dark Knight",
                Year = 2008,
                Summary = "Nội dung phim kể về siêu anh hùng nhưng thực chất là tái hiện lại cuộc chiến cam go giữa thiện và ác, giữa tội ác và công lý, giữa cái xấu xa và tàn bạo. Hai nhân vật trong phim hoàn toàn đối lập nhau, ở hai đầu chiến tuyến của chính và tà nhưng mang lại cho người xem nhiều trăn trở và những bài học đáng quý.",
                Actors = new List<Actor>
                {
                    new Actor { Fullname = "Marlon Brando" },
                    new Actor { Fullname = "Al Pacino " },
                }
            });

            context.SaveChanges();
        }
    }
}