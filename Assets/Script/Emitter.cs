using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Emitter : MonoBehaviour
{
    // Waveプレハブを格納する
    public GameObject[] waves;

    // 現在のWave
    private int currentWave;

    IEnumerator Start()
    {

        // Waveが存在しなければ終了する
        if (waves.Length == 0)
        {
            yield break;
        }

        while (true)
        {

            // Waveを作成（unity的では取得させる）
            GameObject wave = (GameObject)Instantiate(waves[currentWave], transform.position, Quaternion.identity);

            // WaveをEmitterの子にする
            wave.transform.parent = transform;

            // Waveの子が全てDestoryされるまで待機
            while (wave.transform.childCount != 0)
            {
                yield return new WaitForEndOfFrame();
            }

            // Waveの削除
            Destroy(wave);

            // 格納されているWaveを全て実行したらcurrentWaveを0にする（巻き戻し、ループ処理）
            if (waves.Length <= ++currentWave)
            {
                currentWave = 0;
            }

        }
    }
}

