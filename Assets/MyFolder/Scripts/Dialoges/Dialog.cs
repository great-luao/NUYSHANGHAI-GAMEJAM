using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public Dictionary<int, List<string>> sister_dic = new Dictionary<int, List<string>>();

    public Dictionary<int, List<string>> father_dic = new Dictionary<int, List<string>>();

    public Dictionary<int, List<string>> mother_dic = new Dictionary<int, List<string>>();

    public static Dialog Instance;

    private void Start()
    {
        Update_Sister();
        Update_Father();
        Update_Mother();
        Instance = this;
    }

    private void Update_Sister()
    {
        List<string> list0 = new List<string>()
        { "Brother, I can't find my violin bow.",
"I was practicing in the courtyard yesterday and fell asleep slowly.",
"When I woke up, it was gone, but it should still be in the courtyard.",
"I don't know what to do, and I don't dare tell daddy about this.",
"I really want to continue playing the violin...",
"Maybe I should find a dog that can sniff out the location of the bow to help me look for it.",
"I love dogs the most, just like Mom, hehe, and we both hate mice..."};

        List<string> list1 = new List<string>()
        {"Brother, I can't find my violin bow.",
"I was practicing in the courtyard yesterday and fell asleep slowly.",
"When I woke up, it was gone, but it should still be in the courtyard.",
"I don't know what to do, and I don't dare tell daddy about this.",
"I really want to continue playing the violin...",
"Maybe I should find a dog that can sniff out the location of the bow to help me look for it.",
"I love dogs the most, just like Mom, hehe, and we both hate mice..."};

        List<string> list2 = new List<string>()
        {"Brother, I can't find my violin bow.",
"I was practicing in the courtyard yesterday and fell asleep slowly.",
"When I woke up, it was gone, but it should still be in the courtyard.",
"I don't know what to do, and I don't dare tell daddy about this.",
"I really want to continue playing the violin...",
"Maybe I should find a dog that can sniff out the location of the bow to help me look for it.",
"I love dogs the most, just like Mom, hehe, and we both hate mice..."};

        List<string> list3 = new List<string>()
        {"Thank you, brother. Now I can continue playing the violin.",
"Brother, actually... It pains me to see father so down...",
"Even though there's not much I can do. I still wrote a letter to encourage him.",
"However, I'm too scared to personally give it to him.",
"So I hid it under the bed, and now I can't reach it myself.",
"I know I was wrong, I should have bravely faced father and not avoided him.",
"Can you help me give the letter to father?",
"The bed is very heavy, and it takes a lot of strength to lift it.",
"I heard that beetles are the strongest insects, after all."};

        List<string> list4 = new List<string>()
        {"Thank you, brother. Now I can continue playing the violin.",
"Brother, actually... It pains me to see father so down...",
"Even though there's not much I can do. I still wrote a letter to encourage him.",
"However, I'm too scared to personally give it to him.",
"So I hid it under the bed, and now I can't reach it myself.",
"I know I was wrong, I should have bravely faced father and not avoided him.",
"Can you help me give the letter to father?",
"The bed is very heavy, and it takes a lot of strength to lift it.",
"I heard that beetles are the strongest insects, after all."};

        List<string> list5 = new List<string>()
        {"Thank you, brother. Now I can continue playing the violin.",
"Brother, actually... It pains me to see father so down...",
"Even though there's not much I can do. I still wrote a letter to encourage him.",
"However, I'm too scared to personally give it to him.",
"So I hid it under the bed, and now I can't reach it myself.",
"I know I was wrong, I should have bravely faced father and not avoided him.",
"Can you help me give the letter to father?",
"The bed is very heavy, and it takes a lot of strength to lift it.",
"I heard that beetles are the strongest insects, after all."};

        List<string> list6 = new List<string>()
        {"Thank you, brother. Now I can continue playing the violin.",
"Brother, actually... It pains me to see father so down...",
"Even though there's not much I can do. I still wrote a letter to encourage him.",
"However, I'm too scared to personally give it to him.",
"So I hid it under the bed, and now I can't reach it myself.",
"I know I was wrong, I should have bravely faced father and not avoided him.",
"Can you help me give the letter to father?",
"The bed is very heavy, and it takes a lot of strength to lift it.",
"I heard that beetles are the strongest insects, after all."};

        List<string> list7 = new List<string>()
        {"Thank you, brother. Now I can continue playing the violin.",
"Brother, actually... It pains me to see father so down...",
"Even though there's not much I can do. I still wrote a letter to encourage him.",
"However, I'm too scared to personally give it to him.",
"So I hid it under the bed, and now I can't reach it myself.",
"I know I was wrong, I should have bravely faced father and not avoided him.",
"Can you help me give the letter to father?",
"The bed is very heavy, and it takes a lot of strength to lift it.",
"I heard that beetles are the strongest insects, after all."};

        List<string> list8 = new List<string>()
        {"Thank you, brother! It must be because of you that dad has regained his spirit!",
"Hehe, now dad listens to me playing the violin every day, and I feel like life has more meaning too!"};

        List<string> list9 = new List<string>()
        {"Thank you, brother! It must be because of you that dad has regained his spirit!",
"Hehe, now dad listens to me playing the violin every day, and I feel like life has more meaning too!"};

        List<string> list10 = new List<string>()
        {"Thank you, brother! It must be because of you that dad has regained his spirit!",
"Hehe, now dad listens to me playing the violin every day, and I feel like life has more meaning too!"};

        List<string> list11 = new List<string>()
        {"Thank you, brother! It must be because of you that dad has regained his spirit!",
"Hehe, now dad listens to me playing the violin every day, and I feel like life has more meaning too!"};

        List<string> list12 = new List<string>()
        {"Thank you, brother! It must be because of you that dad has regained his spirit!",
"Hehe, now dad listens to me playing the violin every day, and I feel like life has more meaning too!"};

        List<string> list13 = new List<string>()
        {"Thank you, brother! It must be because of you that dad has regained his spirit!",
"Hehe, now dad listens to me playing the violin every day, and I feel like life has more meaning too!"};

        sister_dic.Add(0, list0);
        sister_dic.Add(1, list1);
        sister_dic.Add(2, list2);
        sister_dic.Add(3, list3);
        sister_dic.Add(4, list4);
        sister_dic.Add(5, list5);
        sister_dic.Add(6, list6);
        sister_dic.Add(7, list7);
        sister_dic.Add(8, list8);
        sister_dic.Add(9, list9);
        sister_dic.Add(10, list10);
        sister_dic.Add(11, list11);
        sister_dic.Add(12, list12);
        sister_dic.Add(13, list13);

    }

    private void Update_Father()
    {
        List<string> list0 = new List<string>()
        {"I'm so disappointed in myself, I'm useless, unreliable even to be a father.",
"I owe so much money... I'm even afraid to face my own children",
"afraid that they'll look down on me.",
"Do you think... Grace already hates me? And what about you..."};

        List<string> list1 = new List<string>()
        {"I'm so disappointed in myself, I'm useless, unreliable even to be a father.",
"I owe so much money... I'm even afraid to face my own children",
"afraid that they'll look down on me.",
"Do you think... Grace already hates me? And what about you..."};

        List<string> list2 = new List<string>()
        {"I'm so disappointed in myself, I'm useless, unreliable even to be a father.",
"I owe so much money... I'm even afraid to face my own children",
"afraid that they'll look down on me.",
"Do you think... Grace already hates me? And what about you..."};

        List<string> list3 = new List<string>()
        {"I'm so disappointed in myself, I'm useless, unreliable even to be a father.",
"I owe so much money... I'm even afraid to face my own children",
"afraid that they'll look down on me.",
"Do you think... Grace already hates me? And what about you..."};

        List<string> list4 = new List<string>()
        {"I'm so disappointed in myself, I'm useless, unreliable even to be a father.",
"I owe so much money... I'm even afraid to face my own children",
"afraid that they'll look down on me.",
"Do you think... Grace already hates me? And what about you..."};

        List<string> list5 = new List<string>()
        {"I'm so disappointed in myself, I'm useless, unreliable even to be a father.",
"I owe so much money... I'm even afraid to face my own children",
"afraid that they'll look down on me.",
"Do you think... Grace already hates me? And what about you..."};

        List<string> list6 = new List<string>()
        {"I'm so disappointed in myself, I'm useless, unreliable even to be a father.",
"I owe so much money... I'm even afraid to face my own children",
"afraid that they'll look down on me.",
"Do you think... Grace already hates me? And what about you..."};

        List<string> list7 = new List<string>()
        {"Is this... Grace's letter?",
"Reads silently",
"I understand now. Maybe I should take the initiative to communicate with the children and explain the whole situation.",
"Thank you, my child. You've given me some courage.",
"By the way, Gregor, check your mother's out when you have the chance.",
"After you turned into a beetle... and our family fell apart...",
"She tried hard to face the reality, but we had a lot of conflicts.",
"Recently, it seems like she had lost something very important. Please help her.",
"Even though you can't speak, I know you can understand."};

        List<string> list8 = new List<string>()
        {"Is this... Grace's letter?",
"Reads silently",
"I understand now. Maybe I should take the initiative to communicate with the children and explain the whole situation.",
"Thank you, my child. You've given me some courage.",
"By the way, Gregor, check your mother's out when you have the chance.",
"After you turned into a beetle... and our family fell apart...",
"She tried hard to face the reality, but we had a lot of conflicts.",
"Recently, it seems like she had lost something very important. Please help her.",
"Even though you can't speak, I know you can understand."};

        List<string> list9 = new List<string>()
        {"Is this... Grace's letter?",
"Reads silently",
"I understand now. Maybe I should take the initiative to communicate with the children and explain the whole situation.",
"Thank you, my child. You've given me some courage.",
"By the way, Gregor, check your mother's out when you have the chance.",
"After you turned into a beetle... and our family fell apart...",
"She tried hard to face the reality, but we had a lot of conflicts.",
"Recently, it seems like she had lost something very important. Please help her.",
"Even though you can't speak, I know you can understand."};

        List<string> list10 = new List<string>()
        {"Is this... Grace's letter?",
"Reads silently",
"I understand now. Maybe I should take the initiative to communicate with the children and explain the whole situation.",
"Thank you, my child. You've given me some courage.",
"By the way, Gregor, check your mother's out when you have the chance.",
"After you turned into a beetle... and our family fell apart...",
"She tried hard to face the reality, but we had a lot of conflicts.",
"Recently, it seems like she had lost something very important. Please help her.",
"Even though you can't speak, I know you can understand."};

        List<string> list11 = new List<string>()
        {"Is this... Grace's letter?",
"Reads silently",
"I understand now. Maybe I should take the initiative to communicate with the children and explain the whole situation.",
"Thank you, my child. You've given me some courage.",
"By the way, Gregor, check your mother's out when you have the chance.",
"After you turned into a beetle... and our family fell apart...",
"She tried hard to face the reality, but we had a lot of conflicts.",
"Recently, it seems like she had lost something very important. Please help her.",
"Even though you can't speak, I know you can understand."};

        List<string> list12 = new List<string>()
        {"Is this... Grace's letter?",
"Reads silently",
"I understand now. Maybe I should take the initiative to communicate with the children and explain the whole situation.",
"Thank you, my child. You've given me some courage.",
"By the way, Gregor, check your mother's out when you have the chance.",
"After you turned into a beetle... and our family fell apart...",
"She tried hard to face the reality, but we had a lot of conflicts.",
"Recently, it seems like she had lost something very important. Please help her.",
"Even though you can't speak, I know you can understand."};

        List<string> list13 = new List<string>()
        {"Is this... Grace's letter?",
"Reads silently",
"I understand now. Maybe I should take the initiative to communicate with the children and explain the whole situation.",
"Thank you, my child. You've given me some courage.",
"By the way, Gregor, check your mother's out when you have the chance.",
"After you turned into a beetle... and our family fell apart...",
"She tried hard to face the reality, but we had a lot of conflicts.",
"Recently, it seems like she had lost something very important. Please help her.",
"Even though you can't speak, I know you can understand."};



        father_dic.Add(0, list0);
        father_dic.Add(1, list1);
        father_dic.Add(2, list2);
        father_dic.Add(3, list3);
        father_dic.Add(4, list4);
        father_dic.Add(5, list5);
        father_dic.Add(6, list6);
        father_dic.Add(7, list7);
        father_dic.Add(8, list8);
        father_dic.Add(9, list9);
        father_dic.Add(10, list10);
        father_dic.Add(11, list11);
        father_dic.Add(12, list12);
        father_dic.Add(13, list13);
    }

    private void Update_Mother()
    {
        List<string> list0 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list1 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list2 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list3 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list4 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list5 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list6 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list7 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list8 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list9 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list10 = new List<string>()
        {"Here you come... My child",
"Since this family fell on hard times, we've been struggling to make ends meet for a while.",
"I once thought...about selling the most important thing for me and your father, which is our wedding ring, to make life better...",
"But during my quarrel with your father last time, I impulsively threw the ring into the drain.",
"I'm so sorry to you and your father..."};

        List<string> list11 = new List<string>()
        {"What the hell! What a monster are you! Get the hell out of my room!"};

        List<string> list12 = new List<string>()
        {"What the hell! What a monster are you! Get the hell out of my room!"};

        List<string> list13 = new List<string>()
        {"Wait......This is the ring, the wedding ring! How did you get it?",
       "Never mind, thank you so much my babe, I guess I don't want to sell it right now",
       "Only after losing it, I got to know how important it means to me...",
       "Now I understand that I should stop feeling sorry for myself and try to face life."};



        mother_dic.Add(0, list0);
        mother_dic.Add(1, list1);
        mother_dic.Add(2, list2);
        mother_dic.Add(3, list3);
        mother_dic.Add(4, list4);
        mother_dic.Add(5, list5);
        mother_dic.Add(6, list6);
        mother_dic.Add(7, list7);
        mother_dic.Add(8, list8);
        mother_dic.Add(9, list9);
        mother_dic.Add(10, list10);
        mother_dic.Add(11, list11);
        mother_dic.Add(12, list12);
        mother_dic.Add(13, list13);

    }
}

