using System;

namespace PeachyTween {
  // State
  struct Active {
    public float Progress;
  }

  struct Paused { }
  struct Complete { }
  struct Preserve { }
  struct Reverse { }
  struct PingPong { }
  struct Kill { }
  struct OverrideLerp<T> {
    public LerpFunc<T> Func;
  }

  // Sequences
  struct Sequencer {
    public float JoinTime;
    public float AppendTime;
  }

  struct SequenceMember {
    public int SequenceEntity;
    public float StartTime;

    public SequenceMember(int sequenceEntity, float startTime) {
      SequenceEntity = sequenceEntity;
      StartTime = startTime;
    }
  }

  // Groups
  struct Update { }
  struct UnscaledUpdate { }
  struct LateUpdate { }
  struct UnscaledLateUpdate { }
  struct FixedUpdate { }
  struct UnscaledFixedUpdate { }

  // Lerp filter
  struct Slerp { }
  struct ShortestAngle { }

  // Tween
  struct TweenConfig<T> {
    public T From;
    public T To;
    public Action<T> OnChange;

    public TweenConfig(T from, T to, Action<T> onChange) {
      From = from;
      To = to;
      OnChange = onChange;
    }
  }

  struct TweenState {
    public float Elapsed;
    public float Duration;

    public TweenState(float duration) {
      Elapsed = 0;
      Duration = duration;
    }
  }

  struct Loop {
    public int? CurrentLoop;
    public float LoopDuration;
    public int LoopCount;
  }

  struct Eased {
    public EaseFunc Func;
  }

  struct Target {
    public object Object;
  }
}