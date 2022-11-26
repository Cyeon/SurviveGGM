using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
internal class LoadSpriteOnImage : MonoBehaviour
{
    // Assign in Editor
    public AssetReference reference;

    private Image currentImage = null;

    // Start the load operation on start
    void Start()
    {
        currentImage = GetComponent<Image>();
        AsyncOperationHandle handle = reference.LoadAssetAsync<Sprite>();
        handle.Completed += Handle_Completed;
    }

    // Instantiate the loaded prefab on complete
    private void Handle_Completed(AsyncOperationHandle obj)
    {
        if (obj.Status == AsyncOperationStatus.Succeeded)
        {
            currentImage.sprite = reference.Asset as Sprite;
            currentImage.SetNativeSize();
        }
        else
        {
            Debug.LogError($"AssetReference {reference.RuntimeKey} failed to load.");
        }
    }

    // Release asset when parent object is destroyed
    private void OnDestroy()
    {
        reference.ReleaseAsset();
    }
}