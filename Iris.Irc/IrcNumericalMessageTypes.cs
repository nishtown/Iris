﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iris.Irc
{
    //http://tools.ietf.org/html/rfc1459#section-6
    public enum IrcNumericalMessageTypes
    {
        Error_NoSuchNick = 401,
        Error_NoSuchServer = 402,
        Error_NoSuchChannel = 403,
        Error_CanNotSendToChannel = 404,
        Error_TooManyChannels = 405,
        Error_WasNoSuchNick = 406,
        Error_TooManyTargets = 407,
        Error_NoOrigin = 409,
        Error_NoRecipient = 411,
        Error_NoTextToSend = 412,
        Error_NoTopLevel = 413,
        Error_WildTopLevel = 414,
        Error_UnknowCommand = 421,
        Error_NoMotd = 422,
        Error_NoAdminInfo = 423,
        Error_FileError = 424,
        Error_NoNicknameGiven = 431,
        Error_ErroneusNickname = 432,
        Error_NickNameInUse = 433,
        Error_NickCollision = 436,
        Error_UserNotInChannel = 441,
        Error_NotOnChannel = 442,
        Error_UserOnChannel = 443,
        Error_NoLogin = 444,
        Error_SummonDisabled = 445,
        Error_UserDisabled = 446,
        Error_NotRegistered = 451,
        Error_NeedMoreParameters = 461,
        Error_AlreadyRegistered = 462,
        Error_NoPermissionForHost = 463,
        Error_PasswordMismatch = 464,
        Error_YoureBannedCreep = 465,
        Error_KeySet = 467,
        Error_ChannelIsFull = 471,
        Error_UnknowMode = 472,
        Error_InviteOnlyChannel = 473,
        Error_BannedFromChannel = 474,
        Error_BadChannelKey = 475,
        Error_NoPrivileges = 481,
        Error_ChannelOpPrivilegesNeeded = 482,
        Error_CantKillServer = 483,
        Error_NoOperHost = 491,
        Error_UserModeUnknownFlag = 501,
        Error_UsersDontMatch = 502,

        Reply_None = 300,
        Reply_UserHost = 302,
        Reply_Ison = 303,
        Reply_Away = 301,
        Reply_Unaway = 305,
        Reply_NowAway = 306,
        Reply_WhoisUser = 311,
        Reply_WhoisServer = 312,
        Reply_WhoisOperator = 313,
        Reply_WhoisIdle = 317,
        Reply_EndOfWhois = 318,
        Reply_WhoisChannels = 319,
        Reply_WhoWasUser = 314,
        Reply_EndOfWhoWas = 369,
        Reply_ListStart = 321,
        Reply_List = 322,
        Reply_ListEnd = 323,
        Reply_ChannelModeIs = 324,
        Reply_NoTopic = 331,
        Reply_Topic = 332,
        Reply_Inviting = 341,
        Reply_Summoning = 342,
        Reply_Version = 351,
        Reply_WhoReply = 352,
        Reply_EndOfWho = 315,
        Reply_NameReply = 353,
        Reply_EndOfNames = 366,
        Reply_Links = 364,
        Reply_EndOfLinks = 365,
        Reply_Banlist = 367,
        Reply_EndOfBanlist = 368,
        Reply_Info = 371,
        Reply_EndOfInfo = 374,
        Reply_MotdStart = 375,
        Reply_Motd = 372,
        Reply_EndOfMotd = 376,
        Reply_YoureOper = 381,
        Reply_Rehashing = 382,
        Reply_Time = 391,
        Reply_UsersStart = 392,
        Reply_Users = 393,
        Reply_EndOfUsers = 394,
        Reply_NoUsers = 395,
        Reply_TraceLink = 200,
        Reply_TraceConnecting = 201,
        Reply_TraceHandshake = 202,
        Reply_TraceUnknow = 203,
        Reply_TraceOperator = 204,
        Reply_TraceUser = 205,
        Reply_TraceServer = 206,
        Reply_TraceNewType = 208,
        Reply_TraceLog = 261,
        Reply_StatsLinkInfo = 211,
        Reply_StatsCommands = 212,
        Reply_StatsCLine = 213,
        Reply_StatsNLine = 214,
        Reply_StatsILine = 215,
        Reply_StatsKLine = 216,
        Reply_StatsYLine = 218,
        Reply_EndOfStats = 219,
        Reply_StatsLLine = 241,
        Reply_StatsUptime = 242,
        Reply_StatsOLine = 243,
        Reply_StatsHLine = 244,
        Reply_UserModeIs = 221,
        Reply_LUserClient = 251,
        Reply_LUserOperator = 252,
        Reply_LUserUnknown = 253,
        Reply_LUserChannels = 254,
        Reply_LUserMe = 255,
        Reply_AdminMe = 256,
        Reply_AdminLoc1 = 257,
        Reply_AdminLoc2 = 258,
        Reply_AdminEMail = 259
    }
}