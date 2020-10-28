using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System;
using NavyPqs.Services;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.IO;
using System.ComponentModel.DataAnnotations.Schema;

namespace NavyPqs.Models
{
    public class CwoPqs
    {
        private readonly string[] TwoBravoSectionsByLine =
        {
            "Safety Precautions Fundamentals;101;1;2;3;4;5;6;7;8",
            "Maintenance Fundamentals;102;1;2;3;4;5;6",
            "Security Fundamentals;103;1;2;3;4;5;6;7;8",
            "Leadership Fundamentals;104;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20",
            "Terminology Fundamentals;105;1",
            "U.S. Navy Org. and Naval/Joint Platforms;106;1;2;3;4;5;6.a;6.b;6.c;6.d;6.e;6.f;6.g;6.h;6.i;6.j;7;8;9;10;11;12",
            "Navy Planning Process Fundamentals;107;1;2;3;4;5;6;7;8;9;10;11;12;13",
            "Roe and Authorities Fundamentals;108;1;2;3;4;5;6;7",
            "Intelligence Oversight Fundamentals;109;1;2;3;4;5;6",
            "Radio Prop and Signal Char. Fundamentals;110;1;2;3;4;5;6;7;8;9;10;11",
            "Radar Fundamentals;111;1;2;3;4;5;6;7;8;9",
            "Electronic Warfare Fundamentals;112;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17",
            "Antiship Ship Missile Defense (ASMD) Fundamentals;113;1;2;3;4;5;6;7;8;9;10",
            "Countering Intelligence, Surveillance, Reconnaissance, and Targeting (C-ISRT) Fundamentals;114;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16",
            "National Collection Management Fundamentals;115;1;2;3;4;5;6;7;8;9;10;11",
            "Distributed Signals Intelligence (SIGINT) Operations (DSO) Fundamentals;116;1;2;3;4;5;6;7;8",
            "Direction Finding and Geolocation Fundamentals;117;1;2;3;4;5;6;7;8",
            "Signal Intelligence (SIGINT) Reporting Fundamentals;118;1;2;3;4;5;6;7",
            "Cryptologic Warfare Systems Fundamentals;119;1;2;3;4;5;6;7",
            "Communications Fundamentals;120;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15",
            "Networking Fundamentals;121;1;2;3;4;5;6;7;8;9;10;11",
            "Cybersecurity Fundamentals;122;1;2;3;4;5;6;7",
            "Cyberspace Operations Fundamentals;123;1;2;3;4;5;6;7;8;9",
            "National/Theater Level Support Fundamentals;124;1;2;3;4;5;6",
            "Fleet Cryptologic Operations Fundamentals;125;1;2;3;4;5;6;7;8;9;10",
            "Naval Special Warfare Tactical Information Operations (TIO) Fundamentals;126;1;2;3;4;5;6",
            "Information Operations Fundamentals;127;1;2;3;4;5;6;7",
            "Military Deception (MILDEC) Fundamentals;128;1;2;3;4;5;6;7;8;9;10;11;12",
            "Military Information Support Operations (MISO) Fundamentals;129;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15",
            "Operations Security (OPSEC) Fundamentals;130;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16",
            "Publications and Mission Associated Directives Fundamentals;131;1;2;3;4;5"
        };

        private readonly string[] TwoAlphaSectionsByLine =
        {
            "Safety Precautions;101;1;2;3;4;5;6;7;8;9;10",
            "Maintenance;102;1;2;3;4;5;6",
            "Security;103;1;2;3;4;5;6;7;8",
            "Intelligence Oversight;104;1;2;3;4;5;6;7;8",
            "Leadership;105;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19",
            "Terminology;106;1",
            "U.S.Navy Organizations and Supporting Platforms;107;1;2;3;4;5;6;7;8",
            "Naval and Joint Platforms;108;1;2",
            "Rules of Engagement (ROE) and Weapons Release;109;1;2;3;4;5;6;7",
            "Amphibious Task Force/Task Group Organization and Operations;110;1;2;3;4;5;6;7",
            "Command and Control for Joint Operations;111;1;2",
            "National/Theater Level Support;112;1;2;3;4;5",
            "Fleet Support Operations;113;1;2;3;4;5;6;7;8;9",
            "Intelligence Support;114;1;2;3;4;5;6",
            "Radio Propagation and Signal Characteristics;115;1;2;3;4;5;6;7;8;9;10;11;12;13;14",
            "Signal Intelligence (SIGINT) Reporting;116;1;2;3;4;5;6;7;8",
            "Direction Finding and Geolocation;117;1;2;3;4;5;6;7;8;9",
            "Radar;118;1;2;3;4;5;6;7;8;9;10",
            "National Collection Management;119;1;2;3;4;5;6;7;8;9;10;11",
            "Electronic Warfare (EW);120;1;2;3;4;5;6;7;8;9",
            "Electronic Warfare Support (ES);121;1;2;3;4;5",
            "Electronic Attack (EA);122;1;2;3;4;5;6;7;8;9;10;11",
            "Electronic Protect (EP);123;1;2;3;4;5;6;7;8;9",
            "Cyberspace Operations (CO);124;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18",
            "Networking;125;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17",
            "Military Deception (MILDEC);126;1;2;3;4;5;6;7;8;9",
            "Military Information Support Operations (MISO);127;1;2;3;4;5;6;7;8",
            "Information Assurance (IA);128;1;2;3;4;5;6;7;8;9;10;11;12;13;14",
            "Operations Security (OPSEC);129;1;2;3;4;5;6;7;8;9;10",
            "Publications and Mission Associated Directives;130;1;2;3;4;5",
            "Communications – General – Information Warfare;131;1;2;3;4;5;6;7;8;9;10;11;12;13;14;15;16;17;18;19;20;21;22;23;24;25;26;27;28",
            "Naval Special Warfare Tactical Information Operations (TIO);132;1;2;3;4;5;6;7;8;9;10;11",
            "Administrative, Readiness and Logistical Reporting Fundamentals;133;1;2;3;4;5;6;7;8"
        };

        public List<Section> Sections { get; set; }

        public static CwoPqs NewTwoAlpha()
        {
            var newTwoAlpha = new CwoPqs
            {
                Sections = new List<Section>()
            };
            return NewPqs(newTwoAlpha, newTwoAlpha.TwoAlphaSectionsByLine);
        }

        public static CwoPqs NewTwoBravo()
        {
            var newTwoBravo = new CwoPqs
            {
                Sections = new List<Section>()
            };
            return NewPqs(newTwoBravo, newTwoBravo.TwoBravoSectionsByLine);
        }

        private static CwoPqs NewPqs(CwoPqs pqs, string[] a)
        {
            for (int j = 0; j < a.Count(); j++)
            {
                var values = a[j].Split(';');
                var signaturesBySection = new List<Signature>();
                var signatureCount = values.Count() - 2;
                for (int i = 0; i < signatureCount; i++)

                {
                    signaturesBySection.Add(new Signature { SomeKey = values[i + 2], SignedOff = false });
                };
                pqs.Sections.Add(new Section
                {
                    Name = values[0],
                    Number = values[1],
                    Signatures = signaturesBySection
                });
            }

            return pqs;
        }

        public string ToJson() => JsonSerializer.Serialize(this);

        public bool Export(string path)
        {
            try
            {
                NavyPqs.Services.FileHelper.WriteOver(path, this.ToJson());
            }
            catch (Exception)
            {
                // TODO: Make this more informative.
                return false;
            }
            return true;
        }
    }
}
