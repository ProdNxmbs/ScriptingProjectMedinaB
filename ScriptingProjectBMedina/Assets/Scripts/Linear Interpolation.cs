using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour

{/*   In this case, result = 4
  *   float result = Mathf.Lerp (3f, 5f, 0.5f);
  *   
      The Mathf.Lerp function takes 3 float parameters
  *   
  *   Vector 3 from = new Vector3 (1f, 2f, 3f);
  *   Vector 3 to = new Vector3 (5f, 6f, 7f);
  *   
  *   // Here result = (4, 5, 6)
  *   Vector3 result = Vector3.Lerp (from, to, 0.75f);
  *   
  *   The same principle is applied when using Color.Lerp. In the Color struct, colours are represenmted 
  *   by 4 floats representing red, blue, green and alpha. When using Lerp, these floats are interpolated just as with Mathf.Lerp and Vector3.Lerp.
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);

        Thus over several frames, the lights intensity will tend towards 8 but the rate of its change will slow as it approaches its target. 
        Note that this happens over the course of several frames. If we wanted this to not be frame rate dependent then we could use the following code:
z
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);

        This would mean the change to intensity would happen per second instead of per frame.
    } 
  */
}
