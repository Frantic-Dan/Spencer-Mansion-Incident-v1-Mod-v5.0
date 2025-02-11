﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;

public interface IAnimatorWrapper
{
    bool IsValid { get; }
    float GetFloat(string name);
    float GetFloat(int id);
    void SetFloat(string name, float value);
    void SetFloat(int id, float value);
    bool GetBool(string name);
    bool GetBool(int id);
    void SetBool(string name, bool value);
    void SetBool(int id, bool value);
    int GetInteger(string name);
    int GetInteger(int id);
    void SetInteger(string name, int value);
    void SetInteger(int id, int value);
    void SetTrigger(string name);
    void SetTrigger(int id);
    void ResetTrigger(string name);
    void ResetTrigger(int id);
    bool IsParameterControlledByCurve(string name);
    bool IsParameterControlledByCurve(int id);
    int GetLayerCount();
    string GetLayerName(int layerIndex);
    int GetLayerIndex(string layerName);
    float GetLayerWeight(int layerIndex);
    void SetLayerWeight(int layerIndex, float weight);
    AnimatorStateInfo GetCurrentAnimatorStateInfo(int layerIndex);
    AnimatorStateInfo GetNextAnimatorStateInfo(int layerIndex);
    AnimatorTransitionInfo GetAnimatorTransitionInfo(int layerIndex);
    AnimatorClipInfo[] GetCurrentAnimatorClipInfo(int layerIndex);
    void GetCurrentAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
    void GetNextAnimatorClipInfo(int layerIndex, List<AnimatorClipInfo> clips);
    int GetCurrentAnimatorClipInfoCount(int layerIndex);
    int GetNextAnimatorClipInfoCount(int layerIndex);
    AnimatorClipInfo[] GetNextAnimatorClipInfo(int layerIndex);
    bool IsInTransition(int layerIndex);
    int GetParameterCount();
    AnimatorControllerParameter GetParameter(int index);
    void CrossFadeInFixedTime(string stateName, float transitionDuration);
    void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer);
    void CrossFadeInFixedTime(string stateName, float transitionDuration, int layer, float fixedTime);
    void CrossFadeInFixedTime(int stateNameHash, float transitionDuration);
    void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer);
    void CrossFadeInFixedTime(int stateNameHash, float transitionDuration, int layer, float fixedTime);
    void CrossFade(string stateName, float transitionDuration);
    void CrossFade(string stateName, float transitionDuration, int layer);
    void CrossFade(string stateName, float transitionDuration, int layer, float normalizedTime);
    void CrossFade(int stateNameHash, float transitionDuration);
    void CrossFade(int stateNameHash, float transitionDuration, int layer);
    void CrossFade(int stateNameHash, float transitionDuration, int layer, float normalizedTime);
    void PlayInFixedTime(string stateName);
    void PlayInFixedTime(string stateName, int layer);
    void PlayInFixedTime(string stateName, int layer, float fixedTime);
    void PlayInFixedTime(int stateNameHash);
    void PlayInFixedTime(int stateNameHash, int layer);
    void PlayInFixedTime(int stateNameHash, int layer, float fixedTime);
    void Play(string stateName);
    void Play(string stateName, int layer);
    void Play(string stateName, int layer, float normalizedTime);
    void Play(int stateNameHash);
    void Play(int stateNameHash, int layer);
    void Play(int stateNameHash, int layer, float normalizedTime);
    bool HasState(int layerIndex, int stateID);
}