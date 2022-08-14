using MenuLayout.Shared;

namespace MenuLayout.Shared
{
    public partial class MainLayout
    {
        public List<Menu> menuItems = new List<Menu>{
                new Menu{
                    Title = "Dashboards",
                    Icon = "dashboard",
                    Link = "/"
                },
                new Menu{
                    Title = "My scheme",
                    Icon = "holiday_village",
                    Children = new List<ChildMenu>{
                        new ChildMenu{
                            Title = "Scheme details",
                            Icon = "holiday_village",
                            Link = "/scheme"
                        },
                        new ChildMenu{
                            Title = "Units",
                            Icon = "meeting_room",
                            Link = "/scheme/units"
                        },
                        new ChildMenu{
                            Title = "Owners",
                            Icon = "people",
                            Link = "/scheme/owners"
                        },
                        new ChildMenu{
                            Title = "Buildings",
                            Icon = "apartment",
                            Link = "/scheme/buildings"
                        },
                        new ChildMenu{
                            Title = "Common Property",
                            Icon = "emoji_transportation",
                            Link = "/scheme/common-property"
                        },
                        new ChildMenu{
                            Title = "Sections",
                            Icon = "emoji_transportation",
                            Link = "/scheme/sections",
                        },

                         new ChildMenu{
                             Title = "Counter",
                             Icon = "emoji_transportation",
                             Link = "/counter",
                             Subtitle = "A list of all buildings despite the scheme"
                         }

                    }
                },
                new Menu{
                    Title = "Residents",
                    Icon = "people",
                    Link = "/residents"
                },
                new Menu{
                    Title = "Cases",
                    Icon = "folder_copy",
                    Link = "/cases"
                },
                new Menu{
                    Title = "Appointments",
                    Icon = "assignment_ind",
                    Link = "/appointments"
                },
                new Menu{
                    Title = "Documents",
                    Icon = "description",
                    Link = "/documents"
                },
                new Menu{
                    Title = "Meetings",
                    Icon = "groups",
                    Link = "/meetings"
                },
                new Menu{
                    Title = "Voting",
                    Icon = "how_to_vote",
                    Link = "/voting"
                }
         };
    }
}
