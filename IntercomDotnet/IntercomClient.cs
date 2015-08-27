﻿using IntercomDotNet.Resources;

namespace IntercomDotNet
{
    public class IntercomClient
    {
        public const string ApiRoot = "https://api.intercom.io/";

        public static IntercomClient GetClient(string appid, string apiKey)
        {
            var client = new Client
                             {
                                 UserName = appid,
                                 Password = apiKey,
                                 ApiRoot = ApiRoot
                             };

            return new IntercomClient(
                new Companies(client),
                new Users(client),
                new Notes(client),
                new Tags(client),
                new Events(client),
                new Segments(client));
        }

        private IntercomClient(Companies companies, Users users, Notes notes, Tags tags, Events events, Segments segments)
        {
            Companies = companies;
            Users = users;
            Notes = notes;
            Tags = tags;
            Events = events;
            Segments = segments;
        }

        public Companies Companies { get; private set; }
        public Users Users { get; private set; }
        public Notes Notes { get; private set; }
        public Tags Tags { get; private set; }
        public Events Events { get; private set; }
        public Segments Segments { get; private set; }
    }
}
