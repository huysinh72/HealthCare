using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HealthCare;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace HealthCare.BUS
{
    public class CamBUS
    {

        KhamDinhKy m_form;
        bool _kt;
        public bool kt
        {
            get { return _kt; }
            set { _kt = value; }
        }
        public CamBUS(KhamDinhKy form)
        {
            kt = false;
            m_form = form;
        }
        public void Pulse()
        {
            // Create the SenseManager instance
            PXCMSenseManager senseManager = PXCMSenseManager.CreateInstance();
            //senseManager.EnableStream(PXCMCapture.StreamType.STREAM_TYPE_COLOR, 640, 480, 30);
            // Enable face trackcing
            senseManager.EnableFace();
            senseManager.EnableEmotion();
            // Initialize the pipeline
            senseManager.Init();
            PXCMFaceModule f = senseManager.QueryFace();

            PXCMFaceConfiguration faceConfiguration = f.CreateActiveConfiguration();
            faceConfiguration.detection.isEnabled = true;

            //enable pulse
            PXCMFaceConfiguration.PulseConfiguration pulseConfiguration = faceConfiguration.QueryPulse();
            pulseConfiguration.Enable();

            faceConfiguration.EnableAllAlerts();
            faceConfiguration.ApplyChanges();
            Bitmap databitmap = null;
            //// Stream data
            while (!m_form.isStop())
            {

                // Get a face instance
                PXCMFaceModule face = senseManager.QueryFace();
                if (senseManager.AcquireFrame(true) < pxcmStatus.PXCM_STATUS_NO_ERROR) break;
                if (face != null)
                {
                    // Get face tracking processed data
                    PXCMFaceData faceData = face.CreateOutput();

                    faceData.Update();
                    int numberTrackedFaces = faceData.QueryNumberOfDetectedFaces();
                    // Retrieve the face location data instance
                    PXCMFaceData.Face faceDataFace = faceData.QueryFaceByIndex(0);

                    //Heart Rate + Expression
                    if (faceDataFace != null)
                    {
                        // Retrieve face location data
                        //PXCMFaceData.DetectionData faceDetectionData = faceDataFace.QueryDetection();

                        PXCMFaceData.PoseData facePoseData = faceDataFace.QueryPose();
                        PXCMFaceData.PulseData pulseData = faceDataFace.QueryPulse();

                        // Retrieve expression data
                        if (pulseData != null)
                        {
                            float HeartRate = pulseData.QueryHeartRate();

                            if (HeartRate > 0)
                            {

                                string s = HeartRate.ToString();
                                //------------------------update trong Form, in ra s.      
                                //goi ham chanegPulse trong form 1.
                                m_form.UpdatePulse(s);
                            }
                        }
                    }
                    //cam
                    PXCMCapture.Sample sample = senseManager.QuerySample();
                    if (sample != null)
                    {

                        if (sample.color != null)
                        {
                            PXCMImage image = sample.color;
                            PXCMImage.ImageData data;

                            image.AcquireAccess(PXCMImage.Access.ACCESS_READ,
                                                 PXCMImage.PixelFormat.PIXEL_FORMAT_RGB32,
                                                out data);
                            if (databitmap == null) databitmap = new Bitmap(image.info.width, image.info.height);
                            data.ToBitmap(0, databitmap);
                            //goi ham changeCamBox của form 1.
                            m_form.changePicture(databitmap);
                            image.ReleaseAccess(data);
                            //if (databitmap != null) databitmap.Dispose();
                        }
                    }
                    //emotion
                    PXCMEmotion em = senseManager.QueryEmotion();
                    if (em != null)
                    {
                        PXCMEmotion.EmotionData[] arrData = new PXCMEmotion.EmotionData[10];

                        em.QueryAllEmotionData(0, out arrData);
                        if (arrData != null && arrData[0] != null)
                        {
                            // find the emotion with maximum evidence                                                
                            int idx_outstanding_emotion = 0;
                            int max_evidence = arrData[0].evidence;
                            for (int k = 1; k < 7; k++)
                            {
                                if (arrData[k].evidence < max_evidence) continue;
                                max_evidence = arrData[k].evidence;
                                idx_outstanding_emotion = k;
                            }

                            //------------------------update trong Form, in ra s.                             
                            //goi ham changeEmo
                            string s;
                            switch (arrData[idx_outstanding_emotion].eid)
                            {
                                
                                case PXCMEmotion.Emotion.EMOTION_PRIMARY_JOY:
                                    s = "Vui";
                                    break;
                                case PXCMEmotion.Emotion.EMOTION_PRIMARY_SADNESS:
                                    s = "Buồn";
                                    break;
                                case PXCMEmotion.Emotion.EMOTION_PRIMARY_ANGER:
                                    s = "Tức giận";
                                    break;
                                case PXCMEmotion.Emotion.EMOTION_PRIMARY_SURPRISE:
                                    s = "Ngạc nhiên";
                                    break;
                                case PXCMEmotion.Emotion.EMOTION_PRIMARY_CONTEMPT:
                                    s = "Khinh thường";
                                    break;
                                default:
                                    s = "Bình thường";
                                    break;
                            }

                            m_form.UpdateEmotion(s);
                        }
                    }

                    faceData.Dispose();
                    senseManager.ReleaseFrame();
                }
            }
            senseManager.Dispose();
            //if (senseManager.IsConnected()) senseManager.Close();
        }
    }
}
