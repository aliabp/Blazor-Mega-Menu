namespace Mo.web.Client.Models;

public class MegaColumnItem
{
    //[Key]
    //int Id { get; set; }

    public int ColumnIndex { get; set; }

    public bool IsHeader { get; set; }
    public bool IsTempDeleted { get; set; }

    public string Text { get; set; }

    public string Link { get; set; }
}
