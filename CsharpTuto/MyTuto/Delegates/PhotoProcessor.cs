class PhotoProcessor
{

    public delegate void PhotoFilterHandler(Photo photo);

    public void Process(string path, Action<Photo> filterHandler)
    {
        var photo = Photo.Load(path);

        var filters = new PhotoFilters();
        filterHandler(photo);

        photo.Save();

    }
}
