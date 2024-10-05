using System.Threading.Tasks;
using UnityEngine;

namespace MetalRay
{
    public class Controle : MonoBehaviour{
      [SerializeField] float speed = 5f;
      [SerializeField] float smoothness = 0.1f;
      [SerializeField] float leanAngle = 15f;
      [SerializeField] float leanSpeed = 5f;

      [SerializeField] GameObject model;

      [Header("Bordas da Camera")]
      [SerializeField] Transform cameraFollow;
      [SerializeField] float minX = -8f;
      [SerializeField] float maxX = 8f;
      [SerializeField] float minY = -4f;
      [SerializeField] float maxY = 4f;

      InputReader input;

      Vector3 velocidadeAtual;
      Vector3 targetPosition;
      

        void Start(){
        input = GetComponent<InputReader>();
      }
      
      void Update(){
        targetPosition += new Vector3(input.Move.x, input.Move.y, 0f) * (speed * Time.deltaTime);

        //Calcular min e max de X e Y baseado na camera
        var minPlayerX = cameraFollow.position.x + minX;
        var maxPlayerX= cameraFollow.position.x + maxX;
        var minPlayerY= cameraFollow.position.y + minY;
        var maxPlayerY= cameraFollow.position.y + maxY;

        // junta a posicao do player a visao da camera

        targetPosition.x = Mathf.Clamp(value: targetPosition.x, minPlayerX, maxPlayerX);
        targetPosition.y = Mathf.Clamp(value: targetPosition.y, minPlayerY, maxPlayerY);

        //Lerp a posicao do player para o targetPosition
        transform.position = Vector3.SmoothDamp(current:transform.position, targetPosition, ref velocidadeAtual, smoothness);

        //calcular o efeito de rotacao
        var targetRotationAngle = -input.Move.x * leanAngle;

        var currentYRotation = transform.localEulerAngles.y;
        var newRotation = Mathf.LerpAngle(a:currentYRotation, b:targetRotationAngle, t: leanSpeed * Time.deltaTime);

        //Aplicar o efeito de rotacao
        transform.localEulerAngles = new Vector3(x:0f, newRotation,z:0f);
      }


    }

}
