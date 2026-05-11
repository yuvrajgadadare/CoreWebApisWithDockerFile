using System;
using System.Collections.Generic;

namespace CoreWebApisWithDockerFile.Models;

public partial class TbltrainingTopic
{
    public int TopicId { get; set; }

    public string TopicName { get; set; } = null!;

    public int? Flag { get; set; }

    public string? Publicfolderid { get; set; }
}
