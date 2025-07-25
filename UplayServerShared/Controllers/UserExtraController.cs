using UplayServerShared.Database;
using UplayServerShared.UserModels;

namespace UplayServerShared.Controllers;

public static class UserExtraController
{
    public static void UplayFriendsGameParseToUser(Guid UserId, Uplay.Friends.Game game)
    {
        UserActivity? activity = DBManager.UserActivity.GetOne(x => x.UserId == UserId);
        activity ??= new()
            {
                UserId = UserId
            };
        activity.GameId = game.UplayId;
        activity.ProductName = game.ProductName;
        activity.IsPlaying = true;
        DBManager.UserActivity.Update(activity);
        if (game.GameSession == null)
            return;
        UserGameSession? session = DBManager.UserGameSession.GetOne(x => x.UserId == UserId);
        session ??= new()
            {
                UserId = UserId
            };
        session.SessionData = game.GameSession.GameSessionData.ToBase64();
        session.SessionId = game.GameSession.GameSessionId;
        session.SessionIdV2 = game.GameSession.GameSessionIdV2;
        session.Joinable = game.GameSession.Joinable;
        session.Size = game.GameSession.Size;
        session.MaxSize = game.GameSession.MaxSize;
        DBManager.UserGameSession.Update(session);
    }
}
