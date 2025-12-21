// Copyright © 2025-Present the a2ui-net Authors
//
// Licensed under the Apache License, Version 2.0 (the "License"),
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace A2UI;

/// <summary>
/// Identifies a supported icon name.
/// </summary>
[JsonConverter(typeof(JsonStringEnumConverter<IconName>))]
public enum IconName
{
    /// <summary>Indicates the "accountCircle" icon.</summary>
    [EnumMember(Value = "accountCircle"), JsonStringEnumMemberName("accountCircle")]
    AccountCircle,
    /// <summary>Indicates the "add" icon.</summary>
    [EnumMember(Value = "add"), JsonStringEnumMemberName("add")]
    Add,
    /// <summary>Indicates the "arrowBack" icon.</summary>
    [EnumMember(Value = "arrowBack"), JsonStringEnumMemberName("arrowBack")]
    ArrowBack,
    /// <summary>Indicates the "arrowForward" icon.</summary>
    [EnumMember(Value = "arrowForward"), JsonStringEnumMemberName("arrowForward")]
    ArrowForward,
    /// <summary>Indicates the "attachFile" icon.</summary>
    [EnumMember(Value = "attachFile"), JsonStringEnumMemberName("attachFile")]
    AttachFile,
    /// <summary>Indicates the "calendarToday" icon.</summary>
    [EnumMember(Value = "calendarToday"), JsonStringEnumMemberName("calendarToday")]
    CalendarToday,
    /// <summary>Indicates the "call" icon.</summary>
    [EnumMember(Value = "call"), JsonStringEnumMemberName("call")]
    Call,
    /// <summary>Indicates the "camera" icon.</summary>
    [EnumMember(Value = "camera"), JsonStringEnumMemberName("camera")]
    Camera,
    /// <summary>Indicates the "check" icon.</summary>
    [EnumMember(Value = "check"), JsonStringEnumMemberName("check")]
    Check,
    /// <summary>Indicates the "close" icon.</summary>
    [EnumMember(Value = "close"), JsonStringEnumMemberName("close")]
    Close,
    /// <summary>Indicates the "delete" icon.</summary>
    [EnumMember(Value = "delete"), JsonStringEnumMemberName("delete")]
    Delete,
    /// <summary>Indicates the "download" icon.</summary>
    [EnumMember(Value = "download"), JsonStringEnumMemberName("download")]
    Download,
    /// <summary>Indicates the "edit" icon.</summary>
    [EnumMember(Value = "edit"), JsonStringEnumMemberName("edit")]
    Edit,
    /// <summary>Indicates the "event" icon.</summary>
    [EnumMember(Value = "event"), JsonStringEnumMemberName("event")]
    Event,
    /// <summary>Indicates the "error" icon.</summary>
    [EnumMember(Value = "error"), JsonStringEnumMemberName("error")]
    Error,
    /// <summary>Indicates the "fastForward" icon.</summary>
    [EnumMember(Value = "fastForward"), JsonStringEnumMemberName("fastForward")]
    FastForward,
    /// <summary>Indicates the "favorite" icon.</summary>
    [EnumMember(Value = "favorite"), JsonStringEnumMemberName("favorite")]
    Favorite,
    /// <summary>Indicates the "favoriteOff" icon.</summary>
    [EnumMember(Value = "favoriteOff"), JsonStringEnumMemberName("favoriteOff")]
    FavoriteOff,
    /// <summary>Indicates the "folder" icon.</summary>
    [EnumMember(Value = "folder"), JsonStringEnumMemberName("folder")]
    Folder,
    /// <summary>Indicates the "help" icon.</summary>
    [EnumMember(Value = "help"), JsonStringEnumMemberName("help")]
    Help,
    /// <summary>Indicates the "home" icon.</summary>
    [EnumMember(Value = "home"), JsonStringEnumMemberName("home")]
    Home,
    /// <summary>Indicates the "info" icon.</summary>
    [EnumMember(Value = "info"), JsonStringEnumMemberName("info")]
    Info,
    /// <summary>Indicates the "locationOn" icon.</summary>
    [EnumMember(Value = "locationOn"), JsonStringEnumMemberName("locationOn")]
    LocationOn,
    /// <summary>Indicates the "lock" icon.</summary>
    [EnumMember(Value = "lock"), JsonStringEnumMemberName("lock")]
    Lock,
    /// <summary>Indicates the "lockOpen" icon.</summary>
    [EnumMember(Value = "lockOpen"), JsonStringEnumMemberName("lockOpen")]
    LockOpen,
    /// <summary>Indicates the "mail" icon.</summary>
    [EnumMember(Value = "mail"), JsonStringEnumMemberName("mail")]
    Mail,
    /// <summary>Indicates the "menu" icon.</summary>
    [EnumMember(Value = "menu"), JsonStringEnumMemberName("menu")]
    Menu,
    /// <summary>Indicates the "moreVert" icon.</summary>
    [EnumMember(Value = "moreVert"), JsonStringEnumMemberName("moreVert")]
    MoreVert,
    /// <summary>Indicates the "moreHoriz" icon.</summary>
    [EnumMember(Value = "moreHoriz"), JsonStringEnumMemberName("moreHoriz")]
    MoreHoriz,
    /// <summary>Indicates the "notificationsOff" icon.</summary>
    [EnumMember(Value = "notificationsOff"), JsonStringEnumMemberName("notificationsOff")]
    NotificationsOff,
    /// <summary>Indicates the "notifications" icon.</summary>
    [EnumMember(Value = "notifications"), JsonStringEnumMemberName("notifications")]
    Notifications,
    /// <summary>Indicates the "pause" icon.</summary>
    [EnumMember(Value = "pause"), JsonStringEnumMemberName("pause")]
    Pause,
    /// <summary>Indicates the "payment" icon.</summary>
    [EnumMember(Value = "payment"), JsonStringEnumMemberName("payment")]
    Payment,
    /// <summary>Indicates the "person" icon.</summary>
    [EnumMember(Value = "person"), JsonStringEnumMemberName("person")]
    Person,
    /// <summary>Indicates the "phone" icon.</summary>
    [EnumMember(Value = "phone"), JsonStringEnumMemberName("phone")]
    Phone,
    /// <summary>Indicates the "photo" icon.</summary>
    [EnumMember(Value = "photo"), JsonStringEnumMemberName("photo")]
    Photo,
    /// <summary>Indicates the "play" icon.</summary>
    [EnumMember(Value = "play"), JsonStringEnumMemberName("play")]
    Play,
    /// <summary>Indicates the "print" icon.</summary>
    [EnumMember(Value = "print"), JsonStringEnumMemberName("print")]
    Print,
    /// <summary>Indicates the "refresh" icon.</summary>
    [EnumMember(Value = "refresh"), JsonStringEnumMemberName("refresh")]
    Refresh,
    /// <summary>Indicates the "rewind" icon.</summary>
    [EnumMember(Value = "rewind"), JsonStringEnumMemberName("rewind")]
    Rewind,
    /// <summary>Indicates the "search" icon.</summary>
    [EnumMember(Value = "search"), JsonStringEnumMemberName("search")]
    Search,
    /// <summary>Indicates the "send" icon.</summary>
    [EnumMember(Value = "send"), JsonStringEnumMemberName("send")]
    Send,
    /// <summary>Indicates the "settings" icon.</summary>
    [EnumMember(Value = "settings"), JsonStringEnumMemberName("settings")]
    Settings,
    /// <summary>Indicates the "share" icon.</summary>
    [EnumMember(Value = "share"), JsonStringEnumMemberName("share")]
    Share,
    /// <summary>Indicates the "shoppingCart" icon.</summary>
    [EnumMember(Value = "shoppingCart"), JsonStringEnumMemberName("shoppingCart")]
    ShoppingCart,
    /// <summary>Indicates the "skipNext" icon.</summary>
    [EnumMember(Value = "skipNext"), JsonStringEnumMemberName("skipNext")]
    SkipNext,
    /// <summary>Indicates the "skipPrevious" icon.</summary>
    [EnumMember(Value = "skipPrevious"), JsonStringEnumMemberName("skipPrevious")]
    SkipPrevious,
    /// <summary>Indicates the "star" icon.</summary>
    [EnumMember(Value = "star"), JsonStringEnumMemberName("star")]
    Star,
    /// <summary>Indicates the "starHalf" icon.</summary>
    [EnumMember(Value = "starHalf"), JsonStringEnumMemberName("starHalf")]
    StarHalf,
    /// <summary>Indicates the "starOff" icon.</summary>
    [EnumMember(Value = "starOff"), JsonStringEnumMemberName("starOff")]
    StarOff,
    /// <summary>Indicates the "stop" icon.</summary>
    [EnumMember(Value = "stop"), JsonStringEnumMemberName("stop")]
    Stop,
    /// <summary>Indicates the "upload" icon.</summary>
    [EnumMember(Value = "upload"), JsonStringEnumMemberName("upload")]
    Upload,
    /// <summary>Indicates the "visibility" icon.</summary>
    [EnumMember(Value = "visibility"), JsonStringEnumMemberName("visibility")]
    Visibility,
    /// <summary>Indicates the "visibilityOff" icon.</summary>
    [EnumMember(Value = "visibilityOff"), JsonStringEnumMemberName("visibilityOff")]
    VisibilityOff,
    /// <summary>Indicates the "volumeDown" icon.</summary>
    [EnumMember(Value = "volumeDown"), JsonStringEnumMemberName("volumeDown")]
    VolumeDown,
    /// <summary>Indicates the "volumeMute" icon.</summary>
    [EnumMember(Value = "volumeMute"), JsonStringEnumMemberName("volumeMute")]
    VolumeMute,
    /// <summary>Indicates the "volumeOff" icon.</summary>
    [EnumMember(Value = "volumeOff"), JsonStringEnumMemberName("volumeOff")]
    VolumeOff,
    /// <summary>Indicates the "volumeUp" icon.</summary>
    [EnumMember(Value = "volumeUp"), JsonStringEnumMemberName("volumeUp")]
    VolumeUp,
    /// <summary>Indicates the "warning" icon.</summary>
    [EnumMember(Value = "warning"), JsonStringEnumMemberName("warning")]
    Warning,
}
