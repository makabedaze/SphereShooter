using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageEffect : MonoBehaviour {
    [SerializeField]
    private List<Renderer> _renderers = new List<Renderer>();
    private List<Material> _defaultMaterials = new List<Material>();
    [SerializeField]
    private Material _damageEffectMaterial;

    private void Start()
    {
        InitializeDefaultMaterial();
    }

    public void InitializeDefaultMaterial()
    {
		foreach (Renderer renderer in _renderers)
        {
            _defaultMaterials.Add(renderer.material);
        }
    }

    public IEnumerator Play()
    {
        foreach (Renderer renderer in _renderers)
        {
            renderer.material = _damageEffectMaterial;
        }

        yield return new WaitForSeconds(0.05f);

        for (int i = 0; i < _renderers.Count; i++)
        {
            _renderers[i].material  = _defaultMaterials[i];
        }
    }
}
