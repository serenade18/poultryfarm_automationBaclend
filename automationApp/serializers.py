from rest_framework import serializers
from django.contrib.auth import get_user_model


User = get_user_model()


class UserCreateSerializer(serializers.ModelSerializer):
    user_type = serializers.CharField(default='farmer', required=False)

    class Meta:
        model = User
        fields = ['id', 'email', 'name', 'phone', 'user_type', 'password']
        extra_kwargs = {
            'password': {'write_only': True},
            'car_reg': {'required': False}  # Make car_reg not required globally
        }

    def validate(self, attrs):
        user_type = attrs.get('user_type', 'farmer')
        if user_type not in ['farmer', 'admin']:
            raise serializers.ValidationError("Invalid user type")

        return attrs


class CustomUserSerializer(serializers.ModelSerializer):
    last_login = serializers.DateTimeField(format="%Y-%m-%d %H:%M:%S", read_only=True)

    class Meta:
        model = User
        fields = ['id', 'email', 'name', 'phone', 'user_type', 'last_login']


class UserAccountSerializer(serializers.ModelSerializer):
    class Meta:
        model = User
        fields = ['id', 'email', 'name', 'phone', 'user_type',  'added_on']

