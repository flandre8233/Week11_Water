using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinResultText : CommonUIText
{
    private void OnEnable()
    {

        UpdateText();
    }

    public override void UpdateText()
    {
        if (TimeCountdown.instance.CurrentTime <= 0)
        {
            int HandJokeLeft = HandJokesControll.instance.FieldCount;
            if (HandJokeLeft > 0 && HandJokeLeft < 12)
            {
                HandJokeLeft = 12 - HandJokeLeft;
                text.text = "成功為遊行隊伍爭取時間離開\nwe bought some time for the protest parade to leave\n但代價失去" + HandJokeLeft + "名手足\nBut at the cost of losing " + HandJokeLeft + " siblings\n這就是2019年每週未香港的真實情況\n我不會忘記，香港人都不會忘記\n一齊走，我哋一個都不能少";
            }
            else if (HandJokeLeft >= 12)
            {
                text.text = "成功為遊行隊伍爭取時間離開\nwe bought some time for the protest parade to leave\n做得好，但明天不一定還能全身而退\nGood job, but we may not be able to leave tomorrow\n這就是2019年每週未香港的真實情況\n我不會忘記，香港人都不會忘記\n香港人，煲底除下面罩相見";
            }
        }
        else
        {
            text.text = "遊行隊伍未有足夠時間撤離\nThere was not enough time for the marchers to evacuate\n隨後有更多人被防暴警察包圍被捕\nAfterwards, more people were surrounded by riot police and arrested\n這就是2019年每週未香港的真實情況\n我不會忘記，香港人都不會忘記";
        }

    }
}
