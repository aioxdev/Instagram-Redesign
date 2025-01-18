using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media.Imaging;

namespace InstagramReDesign.Components;

public partial class Feed : UserControl
{
    public static readonly StyledProperty<string> FeedImageProperty =
    AvaloniaProperty.Register<Feed, string>(nameof(FeedImage));
    public string FeedImage
    {
        get => this.GetValue(FeedImageProperty);
        set => SetValue(FeedImageProperty, value);
    }


    public static readonly StyledProperty<Bitmap> FeedProfileProperty =
        AvaloniaProperty.Register<Feed, Bitmap>(nameof(FeedProfile));
    public Bitmap FeedProfile
    {
        get => this.GetValue(FeedProfileProperty);
        set => SetValue(FeedProfileProperty, value);
    }



    public static readonly StyledProperty<string> FeedNameProperty =
        AvaloniaProperty.Register<Feed, string>(nameof(FeedName));
    public string FeedName
    {
        get => this.GetValue(FeedNameProperty);
        set => SetValue(FeedNameProperty, value);
    }



    public static readonly StyledProperty<string> FeedFullNameProperty =
        AvaloniaProperty.Register<Feed, string>(nameof(FeedFullName));
    public string FeedFullName
    {
        get => this.GetValue(FeedFullNameProperty);
        set => SetValue(FeedFullNameProperty, value);
    }



    public static readonly StyledProperty<string> LikeCountProperty =
        AvaloniaProperty.Register<Feed, string>(nameof(LikeCount));
    public string LikeCount
    {
        get => this.GetValue(LikeCountProperty);
        set => SetValue(LikeCountProperty, value);
    }


    public static readonly StyledProperty<string> CommentCountProperty =
        AvaloniaProperty.Register<Feed, string>(nameof(CommentCount));

    public string CommentCount
    {
        get => this.GetValue(CommentCountProperty);
        set => SetValue(CommentCountProperty, value);
    }



    public Feed()
    {
        InitializeComponent();
    }
}