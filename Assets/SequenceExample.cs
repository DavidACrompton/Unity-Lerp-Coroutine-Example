using UnityEngine;
using UnityLerpCoroutines;

public class SequenceExample : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        // Moves the cube
        new Sequence(
            new LerpPosInterval(gameObject, new Vector3(-7, 0, 0), 3f, transformType: TransformType.global),
            new LerpPosInterval(gameObject, new Vector3(-7, 0, 7), 3f, transformType: TransformType.global),
            new LerpPosInterval(gameObject, new Vector3(7, 0, 7), 3f, transformType: TransformType.global),
            new LerpPosInterval(gameObject, new Vector3(7, 0, 0), 3f, transformType: TransformType.global),
            new LerpPosInterval(gameObject, new Vector3(0, 0, 0), 3f, transformType: TransformType.global)
        ).Loop();
        // Rotates the cube
        new Sequence(
            new LerpHprInterval(gameObject, new Vector3(0, 180, 0), 3f),
            new LerpHprInterval(gameObject, new Vector3(0, 0, 0), 3f)
        ).Loop();

        new Sequence(
            new LerpScaleInterval(gameObject, new Vector3(1.5f, 1.5f, 1.5f), 3f),
            new LerpScaleInterval(gameObject, new Vector3(1f, 1f, 1f), 3f)
        ).Loop();
    }
}