using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdation: MonoBehaviour {
 
  public AudioSource beepSource;
  public AudioSource room;
  public AudioSource sadanand;
  public AudioSource mainbuilding;
  public AudioSource firstYearBlock;
  public AudioSource openairtheatre;

  public bool a = true, b = true, c = true, d = true, e = true;

  private void Update() {

    float[] x = new float[10];
    float[] y = new float[10];
    double[] resx = new double[10];
    double[] resy = new double[10];
    double r;

    // *************for index 0(room)*******************
    x[0] = (float) 13.12931 - GPS.Instance.latitude;
    y[0] = (float) 77.58725 - GPS.Instance.longitude;
    resx[0] = x[0] * x[0];
    resy[0] = y[0] * y[0];
    r = 0.0000000225;
    //****************************************************

    // *************for index 1(sadanand)*******************
    x[1] = (float) 13.13076 - GPS.Instance.latitude;
    y[1] = (float) 77.58991 - GPS.Instance.longitude;
    resx[1] = x[1] * x[1];
    resy[1] = y[1] * y[1];

    //****************************************************

    // *************for index 2(mainbuilding)*******************
    x[2] = (float) 13.12900 - GPS.Instance.latitude;
    y[2] = (float) 77.58735 - GPS.Instance.longitude;
    resx[2] = x[2] * x[2];
    resy[2] = y[2] * y[2];

    //****************************************************

    // *************for index 3(FirstYearBlock)*******************
    x[3] = (float) 13.12820 - GPS.Instance.latitude;
    y[3] = (float) 77.58670 - GPS.Instance.longitude;
    resx[3] = x[3] * x[3];
    resy[3] = y[3] * y[3];

    //****************************************************

    // *************for index 4(Basketball court)*******************
    x[4] = (float) 13.12930 - GPS.Instance.latitude;
    y[4] = (float) 77.58650 - GPS.Instance.longitude;
    resx[4] = x[4] * x[4];
    resy[4] = y[4] * y[4];

    //****************************************************

    if (resx[0] + resy[0] <= r) {
      if (a == true) {
        room.Play();
      }
      coordinates.text = "You are near your room";
      a = false;
      b = c = d = e = true;

    } 
    
    else if (resx[1] + resy[1] <= r) {
      if (b == true) {
        sadanand.Play();
      }
      coordinates.text = "YOU ARE NEAR SADANAND GATE NMIT";
      b = false;
      a = c = d = e = true;

    } 
    
    else if (resx[2] + resy[2] <= r) {

      if (c == true) {
        mainbuilding.Play();
      }

      coordinates.text = "YOU ARE NEAR NMIT MAIN BUILDING";
      c = false;
      b = a = d = e = true;
    } 
    
    else if (resx[3] + resy[3] <= r) {
       
      if (d == true) {
        firstYearBlock.Play();
      }
      coordinates.text = "YOU ARE NEAR FIRST YEAR BLOCK";
      d = false;
      b = c = a = e = true;
    } 
    
    else if (resx[4] + resy[4] <= r) {
      if (e == true) {
        openairtheatre.Play();
      }
      coordinates.text = "YOU ARE NEAR BASKETBALL COURT AND OPEN AIR THEATRE";
      e = false;
      b = c = d = a = true;
    } 
    
    else {

      coordinates.text = "KEEP EXPLORING :) ";
      a = b = c = d = e = true;

    }

  }

}