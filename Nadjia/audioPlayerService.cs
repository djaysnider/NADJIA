using System;
using NAudio.Wave;

namespace Nadjia
{
    public class AudioPlayerService : IDisposable
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;
        private bool manualStop;

        public event EventHandler PlaybackFinished;

        public string CurrentFilePath { get; private set; }

        public TimeSpan CurrentTime
        {
            get { return audioFile == null ? TimeSpan.Zero : audioFile.CurrentTime; }
        }

        public TimeSpan TotalTime
        {
            get { return audioFile == null ? TimeSpan.Zero : audioFile.TotalTime; }
        }

        public bool IsLoaded
        {
            get { return audioFile != null; }
        }

     
        public void Load(string filePath)
        {
            manualStop = true;
            StopAndDispose();

            CurrentFilePath = filePath;
            audioFile = new AudioFileReader(filePath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(audioFile);
            outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;

            manualStop = false;
        }

        public void Play()
        {
            if (outputDevice != null)
            {
                manualStop = false;
                outputDevice.Play();
            }
        }

        public void Pause()
        {
            if (outputDevice != null)
                outputDevice.Pause();
        }

        public void Stop()
        {
            if (outputDevice != null && audioFile != null)
            {
                manualStop = true;
                outputDevice.Stop();
                audioFile.CurrentTime = TimeSpan.Zero;
            }
        }

        public void Seek(TimeSpan position)
        {
            if (audioFile == null)
                return;

            if (position < TimeSpan.Zero)
                position = TimeSpan.Zero;

            if (position > audioFile.TotalTime)
                position = audioFile.TotalTime;

            audioFile.CurrentTime = position;
        }

        private void OutputDevice_PlaybackStopped(object sender, StoppedEventArgs e)
        {
            if (!manualStop && audioFile != null && audioFile.Position >= audioFile.Length)
                PlaybackFinished?.Invoke(this, EventArgs.Empty);
        }

        private void StopAndDispose()
        {
            manualStop = true;

            if (outputDevice != null)
            {
                outputDevice.Stop();
                outputDevice.Dispose();
                outputDevice = null;
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
                audioFile = null;
            }
        }

        public void Dispose()
        {
            StopAndDispose();
        }
    }
}